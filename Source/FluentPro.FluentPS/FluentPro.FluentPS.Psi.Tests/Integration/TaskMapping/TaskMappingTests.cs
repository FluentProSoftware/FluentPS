using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using FluentPro.Common.Mapper;
using FluentPro.Common.Mapper.Configurations.PropsMatchers;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Attributes;
using FluentPro.FluentPS.Extensions;
using FluentPro.FluentPS.Mapper;
using FluentPro.FluentPS.Model;
using FluentPro.FluentPS.Psi.Interfaces.Psi;
using FluentPro.FluentPS.Psi.Model.DataSets;
using FluentPro.FluentPS.Psi.Model.Enums;
using FluentPro.FluentPS.Psi.Network;
using FluentPro.FluentPS.Psi.Network.Types;
using FluentPro.FluentPS.Psi.Tests.Integration.TaskMapping.Model;
using FluentPro.FluentPS.Psi.Tests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentPro.FluentPS.Psi.Tests.Integration.TaskMapping
{
    [TestClass]
    public class TaskMappingTests
    {
        private static EnvUtil _envUtil;
        private static IFluentMapper _mapper;
        private static PsiService<IProject> _projectService;
        private static PsiService<ICustomFields> _customFieldsService;

        [TestMethod]
        public void GetProject_ShouldReturnTaskWithCustomFields()
        {
            var customFields = _customFieldsService.Invoke(s => s.ReadCustomFieldsByEntity2(PsEntityType.Task.GetAttr<GuidAttribute>().Guid));
            var projectDataSet = _projectService.Invoke(s => s.ReadProject(Settings.DefaultProjectGuid, DataStoreEnum.WorkingStore));

            var project = new TaskMappingProject();
            _mapper.Map(projectDataSet.Project, project);

            var task = new TaskMappingProjectTask();

            _mapper.Map(projectDataSet.Task, task, externalData: new Dictionary<string, object>
            {
                 { "TASK_UID", task.TaskUid }    
            });

            _mapper.Map(projectDataSet.TaskCustomFields, task, externalData: new Dictionary<string, object>
            {
                { customFields.DataSetName, customFields },
                { "PROJ_UID", Settings.DefaultProjectGuid },
                { "TASK_UID", task.TaskUid }
            });

            Assert.IsTrue(task.TaskName == "Task 1");
            Assert.IsTrue(task.TestTaskText == "10");

            var dict = new Dictionary<string, object>();
            _mapper.Map(projectDataSet.Task, dict, new NopPropsMatcher(), externalData: new Dictionary<string, object>
            {
                 { "TASK_UID", task.TaskUid }    
            });

            _mapper.Map(projectDataSet.TaskCustomFields, dict, new NopPropsMatcher(), externalData: new Dictionary<string, object>
            {
                { customFields.DataSetName, customFields },
                { "PROJ_UID", Settings.DefaultProjectGuid },
                { "TASK_UID", task.TaskUid }
            });

            Assert.IsTrue(dict["TASK_NAME"].Equals("Task 1"));
            Assert.IsTrue(dict["Test - Task - Text"].Equals("10"));
        }

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            _envUtil = new EnvUtil(Settings.PwaUri);
            _mapper = new FluentMapper(new PsMappingConfiguration());
            _projectService = PsiContext.Get<IProject>(Settings.PwaUri);
            _customFieldsService = PsiContext.Get<ICustomFields>(Settings.PwaUri);

            ClassCleanup();

            var customFields = new List<TaskMappingCustomFields>
            {
                new TaskMappingCustomFields
                {
                    MdPropUid = Guid.NewGuid(),
                    MdPropName = "Test - Task - Text",
                    MdEntTypeUid = PsEntityType.Task.GetAttr<GuidAttribute>().Guid,
                    MdPropTypeEnum = PsDataType.String
                },

                new TaskMappingCustomFields
                {
                    MdPropUid = Guid.NewGuid(),
                    MdPropName = "Test - Task - Number",
                    MdEntTypeUid = PsEntityType.Task.GetAttr<GuidAttribute>().Guid,
                    MdPropTypeEnum = PsDataType.Number
                },

                new TaskMappingCustomFields
                {
                    MdPropUid = Guid.NewGuid(),
                    MdPropName = "Test - Task - Cost",
                    MdEntTypeUid = PsEntityType.Task.GetAttr<GuidAttribute>().Guid,
                    MdPropTypeEnum = PsDataType.Cost
                },

                new TaskMappingCustomFields
                {
                    MdPropUid = Guid.NewGuid(),
                    MdPropName = "Test - Task - Duration",
                    MdEntTypeUid = PsEntityType.Task.GetAttr<GuidAttribute>().Guid,
                    MdPropTypeEnum = PsDataType.Duration
                },

                new TaskMappingCustomFields
                {
                    MdPropUid = Guid.NewGuid(),
                    MdPropName = "Test - Task - Date",
                    MdEntTypeUid = PsEntityType.Task.GetAttr<GuidAttribute>().Guid,
                    MdPropTypeEnum = PsDataType.Date
                },

                new TaskMappingCustomFields
                {
                    MdPropUid = Guid.NewGuid(),
                    MdPropName = "Test - Task - YesNo - True",
                    MdEntTypeUid = PsEntityType.Task.GetAttr<GuidAttribute>().Guid,
                    MdPropTypeEnum = PsDataType.YesNo
                },

                new TaskMappingCustomFields
                {
                    MdPropUid = Guid.NewGuid(),
                    MdPropName = "Test - Task - YesNo - False",
                    MdEntTypeUid = PsEntityType.Task.GetAttr<GuidAttribute>().Guid,
                    MdPropTypeEnum = PsDataType.YesNo
                }
            };

            var project = new TaskMappingProject
            {
                ProjUid = Settings.DefaultProjectGuid,
                ProjName = Settings.DefaultProjectName,
                ProjType = ProjectType.Project
            };

            var task = new TaskMappingProjectTask
            {
                TaskUid = Guid.NewGuid(),
                ProjUid = Settings.DefaultProjectGuid,
                TaskName = "Task 1",
                TaskStartDate = DateTime.Now,
                TaskFinishDate = DateTime.Now.AddDays(10),
                TaskWork = 5000.0,
                TestTaskText = "10",
                TestTaskNumber = 20,
                TestTaskCost = 3000,
                TestTaskDuration = 4000,
                TestTaskDate = DateTime.Parse("1991-02-16", CultureInfo.InvariantCulture),
                TestTaskYesNoTrue = true
            };

            _envUtil.CreateCustomFields(customFields);
            var customFieldsDs = _customFieldsService.Invoke(s => s.ReadCustomFieldsByEntity2(PsEntityType.Task.GetAttr<GuidAttribute>().Guid));

            var projectCreateDs = new ProjectDataSet();
            _mapper.Map(project, projectCreateDs.Project);
            _mapper.Map(task, projectCreateDs.Task);
            _mapper.Map(task, projectCreateDs.TaskCustomFields, externalData: new Dictionary<string, object>
            {
                { customFieldsDs.DataSetName, customFieldsDs },
                { "PROJ_UID", Settings.DefaultProjectGuid },
                { "TASK_UID", task.TaskUid }
            });

            var createProjectJobUid = Guid.NewGuid();
            _projectService.Invoke(s => s.QueueCreateProject(createProjectJobUid, projectCreateDs, false));
            _envUtil.Wait(createProjectJobUid);

            var publishProjectJobUid = Guid.NewGuid();
            _projectService.Invoke(p => p.QueuePublish(publishProjectJobUid, Settings.DefaultProjectGuid, true, string.Empty));
            _envUtil.Wait(publishProjectJobUid);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _envUtil.DeleteProject(Settings.DefaultProjectGuid);
            _envUtil.DeleteCustomFields("Test - Task");
        }
    }
}
