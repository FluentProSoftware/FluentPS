using System;
using System.Collections.Generic;
using FluentPro.Common.Mapper;
using FluentPro.Common.Mapper.Configurations.PropertyNameConverters;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Mapper;
using FluentPro.FluentPS.Psi.Interfaces.Psi;
using FluentPro.FluentPS.Psi.Model.DataSets;
using FluentPro.FluentPS.Psi.Model.Enums;
using FluentPro.FluentPS.Psi.Network;
using FluentPro.FluentPS.Psi.Network.Types;
using FluentPro.FluentPS.Psi.Tests.Integration.BasicProjectMapping.Model;
using FluentPro.FluentPS.Psi.Tests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentPro.FluentPS.Psi.Tests.Integration.BasicProjectMapping
{
    [TestClass]
    public class BasicProjectMappingTests
    {
        private static PsiService<IProject> _projectService;
        private static PsiService<ICustomFields> _customFieldsService;

        private static IFluentMapper _mapper;
            
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            _mapper = new FluentMapper(new PsMappingConfiguration());
            _projectService = PsiContext.Get<IProject>(Settings.PwaUri);
            _customFieldsService = PsiContext.Get<ICustomFields>(Settings.PwaUri);

            ClassCleanup();

            var simpleProject = new SimpleProject
            {
                ProjUid = Settings.DefaultProjectGuid,
                ProjName = Settings.DefaultProjectName,
                ProjType = (int)ProjectType.Project,
                WprojDescription = Settings.DefaultProjectName
            };

            var ds = new ProjectDataSet();
            _mapper.Map(simpleProject, ds.Project);

            var createProjectJobUid = Guid.NewGuid();
            _projectService.Invoke(p => p.QueueCreateProject(createProjectJobUid, ds, false));
            QueueUtil.Wait(createProjectJobUid);

            var publishProjectJobUid = Guid.NewGuid();
            _projectService.Invoke(p => p.QueuePublish(publishProjectJobUid, Settings.DefaultProjectGuid, true, string.Empty));
            Assert.IsTrue(QueueUtil.Wait(publishProjectJobUid));
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            try
            {
                var checkInProjectJobUid = Guid.NewGuid();
                _projectService.Invoke(p => p.QueueCheckInProject(checkInProjectJobUid, Settings.DefaultProjectGuid, true, Settings.DefaultSessionGuid, "Unit tests session"));
                QueueUtil.Wait(checkInProjectJobUid);
            }
            catch { }

            try
            {
                var deleteProjectJobUid = Guid.NewGuid();
                _projectService.Invoke(p => p.QueueDeleteProjects(deleteProjectJobUid, true, new[] { Settings.DefaultProjectGuid }, true));
                QueueUtil.Wait(deleteProjectJobUid);
            }
            catch { }
        }

        //[TestMethod]
        //public void CreateCustomFields()
        //{
        //    var customFieldsService = PsiContext.Get<ICustomFields>(Settings.PwaUri);

        //    var customFieldsDs = new CustomFieldDataSet();

        //    var row = customFieldsDs.CustomFields.NewCustomFieldsRow();
        //    row.MD_PROP_UID = new Guid("573050DE-58A3-44C7-A22A-318C3290C8E5");
        //    row.MD_PROP_NAME = "1 Custom Field";
        //    row.MD_ENT_TYPE_UID = PsEntityType.Project.GetAttr<GuidAttribute>().Guid;
        //    row.MD_PROP_TYPE_ENUM = (byte)PsConversionType.String;

        //    customFieldsDs.CustomFields.AddCustomFieldsRow(row);

        //    customFieldsService.Invoke(c => c.CreateCustomFields2(customFieldsDs, false, true));
        //}

        [TestMethod]
        public void GetProject_ByGuid_ShouldReturnProjectEntity()
        {
            var dataSet = _projectService.Invoke(p => p.ReadProject(Settings.DefaultProjectGuid, DataStoreEnum.WorkingStore));

            var result = new SimpleProject();
            _mapper.Map(dataSet.Project, result);

            Assert.IsTrue(result.ProjName == Settings.DefaultProjectName);
            Assert.IsTrue(result.ProjUid == Settings.DefaultProjectGuid);
            Assert.IsTrue(result.ProjType == ProjectType.Project);
            Assert.IsTrue(result.WprojDescription == Settings.DefaultProjectName);
        }

        [TestMethod]
        public void GetProject_ByGuid_ShouldReturnDictionary()
        {
            var dataSet = _projectService.Invoke(p => p.ReadProject(Settings.DefaultProjectGuid, DataStoreEnum.WorkingStore));

            var result = new Dictionary<string, object>();
            _mapper.Map(dataSet.Project, result, new LeaveOriginalNamePropertyNameConverter());

            Assert.IsTrue(result["PROJ_NAME"].Equals(Settings.DefaultProjectName));
            Assert.IsTrue(result["PROJ_UID"].Equals(Settings.DefaultProjectGuid));
            Assert.IsTrue(result["WPROJ_DESCRIPTION"].Equals(Settings.DefaultProjectName));
        }

        [TestMethod]
        public void GetProject_ByGuid_ShouldReturnDictionaryWithCustomFields()
        {
            var projectDataSet = _projectService.Invoke(p => p.ReadProject(Settings.DefaultProjectGuid, DataStoreEnum.WorkingStore));
            var customFieldsDataSet = _customFieldsService.Invoke(s => s.ReadCustomFields(string.Empty, false));

            var result = new Dictionary<string, object>();

            _mapper.Map(
                projectDataSet.Project,
                result,
                new LeaveOriginalNamePropertyNameConverter());

            _mapper.Map(
                projectDataSet.ProjectCustomFields,
                result,
                new LeaveOriginalNamePropertyNameConverter(),
                externalData: new Dictionary<string, object> 
                {
                    { customFieldsDataSet.DataSetName, customFieldsDataSet }
                });

            Assert.IsTrue(result["PROJ_NAME"].Equals(Settings.DefaultProjectName));
            //TODO: Uncoment after full support for custom fields.
            //Assert.IsTrue(result["Project - Text"].Equals("10"));
        }
    }
}
