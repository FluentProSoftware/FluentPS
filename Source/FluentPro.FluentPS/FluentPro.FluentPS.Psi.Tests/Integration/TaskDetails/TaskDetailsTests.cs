using System;
using System.Collections.Generic;
using System.Linq;
using FluentPro.Common.Mapper;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Mapper;
using FluentPro.FluentPS.Psi.Interfaces.Psi;
using FluentPro.FluentPS.Psi.Model.DataSets;
using FluentPro.FluentPS.Psi.Model.Enums;
using FluentPro.FluentPS.Psi.Network.Types;
using FluentPro.FluentPS.Psi.Tests.Integration.TaskDetails.Model;
using FluentPro.FluentPS.Psi.Tests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentPro.FluentPS.Psi.Tests.Integration.TaskDetails
{
    [TestClass]
    public class TaskDetailsTests
    {
        private static readonly Guid SessionGuid = new Guid("F496FB67-E3D1-4F47-9116-41AF12FEF78C");

        private static readonly Uri PwaUri = Settings.PwaUri;

        private static readonly Guid ProjectGuid = new Guid("CFCDD094-37D6-43BF-8FA4-2F2994C03862");

        private static readonly Guid AssnGuid = new Guid("8F297DDD-3390-48EE-9758-C58D5826297A");

        private static readonly Guid TaskGuid = new Guid("6A7BEA97-C124-4656-94AE-8F4A7FF34DFC");

        private static readonly Guid ResGuid = Guid.NewGuid();

        private static readonly string ResName = "Task Details Test Resource";

        private static readonly string ProjectName = "Task Details Test Project";

        private static PsiService<IProject> _projectService;
        private static PsiService<IResource> _resourceService;

        private static readonly IFluentMapper Mapper = new FluentMapper(new PsMappingConfiguration());

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            _projectService = Network.PsiContext.Get<IProject>(PwaUri);
            _resourceService = Network.PsiContext.Get<IResource>(PwaUri);

            ClassCleanup();

            var project = new TaskDetailsProject
            {
                ProjUid = ProjectGuid,
                ProjName = ProjectName,
                ProjType = (int)ProjectType.Project,
                WprojDescription = ProjectName,
                Tasks = new List<TaskDetailsTask>
                {
                    new TaskDetailsTask { TaskName = "Task 1", TaskUid = TaskGuid, ProjUid = ProjectGuid },
                    new TaskDetailsTask { TaskName = "Task 2", TaskUid = Guid.NewGuid(), ProjUid = ProjectGuid },
                    new TaskDetailsTask { TaskName = "Task 3", TaskUid = Guid.NewGuid(), ProjUid = ProjectGuid },
                }
            };

            var resource = new TaskDetailsResource
            {
                ResUid = ResGuid,
                ResName = ResName
            };

            var projectTeamResource = new TaskDetailsProjectTeamResource
            {
                ResUid = ResGuid,
                ProjUid = ProjectGuid,
                NewResUid = ResGuid
            };

            var assn = new TaskDetailsAssignment
            {
                AssnUid = AssnGuid,
                ResUid = ResGuid,
                ProjUid = ProjectGuid,
                TaskUid = TaskGuid
            };

            var resDs = new ResourceDataSet();
            Mapper.Map(resource, resDs.Resources);

            var projectCreateDs = new ProjectDataSet();
            Mapper.Map(project, projectCreateDs.Project);
            Mapper.Map(project.Tasks, projectCreateDs.Task);

            var projectTeamDs = new ProjectTeamDataSet();
            Mapper.Map(projectTeamResource, projectTeamDs.ProjectTeam);

            var projectAssnDs = new ProjectDataSet();
            Mapper.Map(assn, projectAssnDs.Assignment);

            _resourceService.Invoke(s => s.CreateResources(resDs, false, true));

            var createProjectJobUid = Guid.NewGuid();
            _projectService.Invoke(p => p.QueueCreateProjectAndCheckOut(createProjectJobUid, SessionGuid, "Unit tests session", projectCreateDs, false));
            QueueUtil.Wait(createProjectJobUid);

            var updateProjectTeamJobUid = Guid.NewGuid();
            _projectService.Invoke(p => p.QueueUpdateProjectTeam(updateProjectTeamJobUid, SessionGuid, ProjectGuid, projectTeamDs));
            QueueUtil.Wait(updateProjectTeamJobUid);

            //Describe common error : GeneralOnlyInsertsAllowed
            //https://social.msdn.microsoft.com/Forums/en-US/f6cd2eee-3748-47c1-b199-61872b9288b0/im-getting-error-generalonlyinsertsallowed-when-trying-to-add-a-new-task-to-a-project?forum=project2010custprog
            var assnUpdateJobUid = Guid.NewGuid();
            _projectService.Invoke(s => s.QueueAddToProject(assnUpdateJobUid, SessionGuid, projectAssnDs, false));
            QueueUtil.Wait(assnUpdateJobUid);

            var checkInProjectJobUid = Guid.NewGuid();
            _projectService.Invoke(p => p.QueueCheckInProject(checkInProjectJobUid, ProjectGuid, false, SessionGuid, "Unit tests session"));
            QueueUtil.Wait(checkInProjectJobUid);

            var publishProjectJobUid = Guid.NewGuid();
            _projectService.Invoke(p => p.QueuePublish(publishProjectJobUid, ProjectGuid, true, string.Empty));
            QueueUtil.Wait(publishProjectJobUid);

            var publishSummaryProjectJobUid = Guid.NewGuid();
            _projectService.Invoke(p => p.QueuePublishSummary(publishSummaryProjectJobUid, ProjectGuid));
            QueueUtil.Wait(publishSummaryProjectJobUid);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            try
            {
                var checkInProjectJobUid = Guid.NewGuid();
                _projectService.Invoke(p => p.QueueCheckInProject(checkInProjectJobUid, ProjectGuid, true, SessionGuid, "Unit tests session"));
                QueueUtil.Wait(checkInProjectJobUid);
            }
            catch { }

            try
            {
                var deleteProjectJobUid = Guid.NewGuid();
                _projectService.Invoke(p => p.QueueDeleteProjects(deleteProjectJobUid, true, new[] { ProjectGuid }, true));
                QueueUtil.Wait(deleteProjectJobUid);
            }
            catch { }

            try
            {
                var resources = _resourceService.Invoke(s => s.ReadResources("", false));

                var toDelete = resources.Resources
                    .Cast<ResourceDataSet.ResourcesRow>()
                    .Where(r => r.RES_NAME.StartsWith(ResName))
                    .ToList();

                var toCheckout = toDelete
                    .Where(r => r.IsRES_CHECKOUTBYNull())
                    .Select(r => r.RES_UID)
                    .ToArray();

                _resourceService.Invoke(s => s.CheckOutResources(toCheckout));

                var deleteResourceJobUid = Guid.NewGuid();
                _resourceService.Invoke(s => s.DeleteResources(toDelete.Select(r => r.RES_UID).ToArray(), "Removed by unit tests"));
                QueueUtil.Wait(deleteResourceJobUid);
            }
            catch { }
        }

        [TestMethod]
        public void GetProject_ByGuid_ShouldReturnTaskDetailsObject()
        {
            var projectDataSet = _projectService.Invoke(p => p.ReadProject(ProjectGuid, DataStoreEnum.WorkingStore));

            var assignment = projectDataSet
                .Assignment
                .Rows
                .Cast<ProjectDataSet.AssignmentRow>()
                .FirstOrDefault(assn => assn.ASSN_UID == AssnGuid);

            var task = projectDataSet
                .Task
                .Rows
                .Cast<ProjectDataSet.TaskRow>()
                .FirstOrDefault(tsk => tsk.TASK_UID == assignment.TASK_UID);

            var taskDetails = new Model.TaskDetails();
            Mapper.Map(task, taskDetails);
            Mapper.Map(assignment, taskDetails);

            Assert.IsTrue(taskDetails.TaskName == "Task 1");
        }
    }
}
