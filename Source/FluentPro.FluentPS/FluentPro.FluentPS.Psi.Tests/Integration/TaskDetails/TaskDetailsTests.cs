using System;
using System.Collections.Generic;
using System.Linq;
using FluentPro.Common.Mapper;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Mapper;
using FluentPro.FluentPS.Psi.Interfaces.Psi;
using FluentPro.FluentPS.Psi.Model.DataSets;
using FluentPro.FluentPS.Psi.Model.Enums;
using FluentPro.FluentPS.Psi.Network;
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

        private static Guid ResGuid;

        private static readonly string ProjectName = "Task Details Test Project";

        private static PsiService<IProject> _projectService;
        private static PsiService<IResource> _resourceService;
        private static PsiService<IStatusing> _statusingService;

        private static readonly IFluentMapper Mapper = new FluentMapper(new PsMappingConfiguration());

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            _projectService = PsiContext.Get<IProject>(PwaUri);
            _resourceService = PsiContext.Get<IResource>(PwaUri);
            _statusingService = PsiContext.Get<IStatusing>(PwaUri);
            ResGuid = _resourceService.Invoke(s => s.GetCurrentUserUid());

            ClassCleanup();

            var project = new TaskDetailsProject
            {
                ProjUid = ProjectGuid,
                ProjName = ProjectName,
                ProjType = (int)ProjectType.Project,
                WprojDescription = ProjectName,
                Tasks = new List<TaskDetailsTask>
                {
                    new TaskDetailsTask { TaskName = "Task 1", TaskWork = 10000, TaskStartDate = DateTime.Now, TaskFinishDate = DateTime.Now.AddDays(3), TaskUid = TaskGuid, ProjUid = ProjectGuid },
                    new TaskDetailsTask { TaskName = "Task 2", TaskWork = 20000, TaskStartDate = DateTime.Now, TaskFinishDate = DateTime.Now.AddDays(3), TaskUid = Guid.NewGuid(), ProjUid = ProjectGuid },
                    new TaskDetailsTask { TaskName = "Task 3", TaskWork = 30000, TaskStartDate = DateTime.Now, TaskFinishDate = DateTime.Now.AddDays(3), TaskUid = Guid.NewGuid(), ProjUid = ProjectGuid },
                }
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


            var projectCreateDs = new ProjectDataSet();
            Mapper.Map(project, projectCreateDs.Project);
            Mapper.Map(project.Tasks, projectCreateDs.Task);

            var projectTeamDs = new ProjectTeamDataSet();
            Mapper.Map(projectTeamResource, projectTeamDs.ProjectTeam);

            var projectAssnDs = new ProjectDataSet();
            Mapper.Map(assn, projectAssnDs.Assignment);

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

        [ClassCleanup()]
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
                _statusingService.Invoke(s => s.DeleteStatusingInformationForProject(new[] { ProjectGuid }, DateTime.MinValue, DateTime.MaxValue));
            }
            catch { }

            try
            {
                var deleteProjectJobUid = Guid.NewGuid();
                _projectService.Invoke(p => p.QueueDeleteProjects(deleteProjectJobUid, true, new[] { ProjectGuid }, true));
                QueueUtil.Wait(deleteProjectJobUid);
            }
            catch { }

            //try
            //{
            //    var resources = _resourceService.Invoke(s => s.ReadResources("", false));

            //    var toDelete = resources.Resources
            //        .Cast<ResourceDataSet.ResourcesRow>()
            //        .Where(r => r.RES_NAME.StartsWith(ResName))
            //        .ToList();

            //    var toCheckout = toDelete
            //        .Where(r => r.IsRES_CHECKOUTBYNull())
            //        .Select(r => r.RES_UID)
            //        .ToArray();

            //    _resourceService.Invoke(s => s.CheckOutResources(toCheckout));

            //    var deleteResourceJobUid = Guid.NewGuid();
            //    _resourceService.Invoke(s => s.DeleteResources(toDelete.Select(r => r.RES_UID).ToArray(), "Removed by unit tests"));
            //    QueueUtil.Wait(deleteResourceJobUid);
            //}
            //catch { }
        }

        [TestMethod]
        public void GetTaskDetailsFromStatusingDataSet_ByGuid_ShouldReturnTaskDetailsObject()
        {
            var currentDate = DateTime.Now;
            var changesXml = @" 
                <Changes>
                  <Proj ID='{0}'>
                    <Task ID='{1}'>
                        {2}
                    </Task>
                  </Proj>
                </Changes>";

            var changeXml = @"<Change PID='{0}'>{1}</Change>";

            var taskDetails = GetTaskDetailsFromStatusing();
            Assert.IsTrue(taskDetails.TaskName == "Task 1");
            Assert.IsTrue(taskDetails.TaskWork == 10000);

            taskDetails.TaskRemWork = 5000;
            taskDetails.TaskStartDate = currentDate.AddDays(1);
            taskDetails.TaskFinishDate = currentDate.AddDays(4);

            var changes = string.Empty;
            changes += string.Format(changeXml, 184549382, taskDetails.TaskRemWork);
            changes += string.Format(changeXml, 184549386, taskDetails.TaskStartDate);
            changes += string.Format(changeXml, 184549387, taskDetails.TaskFinishDate);

            var xml = string.Format(changesXml, taskDetails.ProjUid, taskDetails.TaskUid, changes);

            _statusingService.Invoke(s => s.UpdateStatus(xml));
            _statusingService.Invoke(s => s.UpdateStatus(xml));
            _statusingService.Invoke(s => s.UpdateStatus(xml));

            var updatedTaskDetails = GetTaskDetailsFromStatusing();
            Assert.IsTrue(updatedTaskDetails.TaskRemWork == updatedTaskDetails.TaskWork);
            Assert.IsTrue(updatedTaskDetails.TaskRemWork == 5000, "Actual: {0}, Expected: 50", updatedTaskDetails.TaskRemWork);
            Assert.IsTrue(updatedTaskDetails.TaskStartDate.ToLongDateString() == currentDate.AddDays(1).ToLongDateString());
            Assert.IsTrue(updatedTaskDetails.TaskFinishDate.ToLongDateString() == currentDate.AddDays(4).ToLongDateString());
        }

        private Model.TaskDetails GetTaskDetailsFromStatusing()
        {
            var statusingDs = _statusingService.Invoke(s => s.ReadStatus(Guid.Empty, DateTime.MinValue, DateTime.MaxValue));

            var assignment = statusingDs
                .Assignments
                .Rows
                .Cast<StatusingDataSet.AssignmentsRow>()
                .FirstOrDefault(assn => assn.ASSN_UID == AssnGuid);

            var task = statusingDs
                .Tasks
                .Rows
                .Cast<StatusingDataSet.TasksRow>()
                .FirstOrDefault(tsk => tsk.TASK_UID == assignment.TASK_UID);

            var taskDetails = new Model.TaskDetails();
            Mapper.Map(assignment, taskDetails);
            Mapper.Map(task, taskDetails);

            return taskDetails;
        }
    }
}
