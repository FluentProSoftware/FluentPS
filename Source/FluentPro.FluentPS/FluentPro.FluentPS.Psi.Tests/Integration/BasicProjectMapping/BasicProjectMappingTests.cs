using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Xml.Schema;
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
using FluentPro.FluentPS.Psi.Tests.Integration.BasicProjectMapping.Model;
using FluentPro.FluentPS.Psi.Tests.Integration.BasicProjectMapping.PropValueConverters;
using FluentPro.FluentPS.Psi.Tests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentPro.FluentPS.Psi.Tests.Integration.BasicProjectMapping
{
    //// TODO: Describe common data types, write about decimal for NUMBER, COST, WORK
    /// When maping Duda
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

            var cfds = new CustomFieldDataSet();
            var cfs = new List<BasicProjectCustomField>
            {
                new BasicProjectCustomField
                { 
                    MdPropUid = Guid.NewGuid(), 
                    MdPropName = "Test - Project - Text", 
                    MdEntTypeUid = PsEntityType.Project.GetAttr<GuidAttribute>().Guid, 
                    MdPropTypeEnum = PsDataType.String
                },

                new BasicProjectCustomField
                { 
                    MdPropUid = Guid.NewGuid(), 
                    MdPropName = "Test - Project - Number", 
                    MdEntTypeUid = PsEntityType.Project.GetAttr<GuidAttribute>().Guid, 
                    MdPropTypeEnum = PsDataType.Number
                },
                
                new BasicProjectCustomField
                {
                    MdPropUid = Guid.NewGuid(),
                    MdPropName = "Test - Project - Cost",
                    MdEntTypeUid = PsEntityType.Project.GetAttr<GuidAttribute>().Guid,
                    MdPropTypeEnum = PsDataType.Cost
                },
                
                new BasicProjectCustomField
                {
                    MdPropUid = Guid.NewGuid(),
                    MdPropName = "Test - Project - Duration",
                    MdEntTypeUid = PsEntityType.Project.GetAttr<GuidAttribute>().Guid,
                    MdPropTypeEnum = PsDataType.Duration
                },

                new BasicProjectCustomField
                {
                    MdPropUid = Guid.NewGuid(),
                    MdPropName = "Test - Project - Date",
                    MdEntTypeUid = PsEntityType.Project.GetAttr<GuidAttribute>().Guid,
                    MdPropTypeEnum = PsDataType.Date
                },

                new BasicProjectCustomField
                {
                    MdPropUid = Guid.NewGuid(),
                    MdPropName = "Test - Project - YesNo - True",
                    MdEntTypeUid = PsEntityType.Project.GetAttr<GuidAttribute>().Guid,
                    MdPropTypeEnum = PsDataType.YesNo
                },

                new BasicProjectCustomField
                {
                    MdPropUid = Guid.NewGuid(),
                    MdPropName = "Test - Project - YesNo - False",
                    MdEntTypeUid = PsEntityType.Project.GetAttr<GuidAttribute>().Guid,
                    MdPropTypeEnum = PsDataType.YesNo
                }
            };

            _mapper.Map(cfs, cfds.CustomFields);
            _customFieldsService.Invoke(c => c.CreateCustomFields2(cfds, false, true));

            var customFieldsDataSet = _customFieldsService.Invoke(s => s.ReadCustomFieldsByEntity2(PsEntityType.Project.GetAttr<GuidAttribute>().Guid));
            var simpleProject = new BasicProject
            {
                ProjUid = Settings.DefaultProjectGuid,
                ProjName = Settings.DefaultProjectName,
                ProjType = (int)ProjectType.Project,
                WprojDescription = Settings.DefaultProjectName,
                TestProjectText = "10",
                TestProjectNumber = 20,
                TestProjectCost = 3000,
                TestProjectDuration = 4000,
                TestProjectDate = DateTime.Parse("1991-02-16", CultureInfo.InvariantCulture),
                TestProjectYesNoTrue = true
            };

            var ds = new ProjectDataSet();
            _mapper.Map(simpleProject, ds.Project);
            _mapper.Map(simpleProject, ds.ProjectCustomFields, externalData: new Dictionary<string, object>
            {
                { customFieldsDataSet.DataSetName, customFieldsDataSet },
                { "PROJ_UID", Settings.DefaultProjectGuid}
            });

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

            try
            {
                var customFields = _customFieldsService.Invoke(s => s.ReadCustomFieldsByEntity2(PsEntityType.Project.GetAttr<GuidAttribute>().Guid));

                var toDelete = customFields
                    .CustomFields
                    .Cast<CustomFieldDataSet.CustomFieldsRow>()
                    .Where(r => r.MD_PROP_NAME.StartsWith("Test"))
                    .ToList();

                var toCheckout = toDelete
                    .Where(r => r.IsMD_PROP_CHECKOUTBYNull())
                    .Select(r => r.MD_PROP_UID)
                    .ToArray();

                _customFieldsService.Invoke(s => s.CheckOutCustomFields(toCheckout));
                _customFieldsService.Invoke(s => s.DeleteCustomFields(toDelete.Select(f => f.MD_PROP_UID).ToArray()));
            }
            catch { }
        }

        [TestMethod]
        public void GetProject_ByGuid_ShouldReturnProjectEntity()
        {
            var dataSet = _projectService.Invoke(p => p.ReadProject(Settings.DefaultProjectGuid, DataStoreEnum.WorkingStore));

            var result = new BasicProject();
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
            _mapper.Map(dataSet.Project, result, new NopPropsMatcher());

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
                new NopPropsMatcher());

            _mapper.Map(
                projectDataSet.ProjectCustomFields,
                result,
                new NopPropsMatcher(),
                externalData: new Dictionary<string, object> 
                {
                    { customFieldsDataSet.DataSetName, customFieldsDataSet },
                    { "PROJ_UID", result["PROJ_UID"] }
                });

            Assert.IsTrue(((string)result["PROJ_NAME"]).Equals(Settings.DefaultProjectName));
            Assert.IsTrue(((string)result["Test - Project - Text"]).Equals("10"));
            Assert.IsTrue(((decimal)result["Test - Project - Number"]).Equals(20));
            Assert.IsTrue(((decimal)result["Test - Project - Cost"]).Equals(3000));
            Assert.IsTrue(((int)result["Test - Project - Duration"]).Equals(4000));
            Assert.IsTrue(((DateTime)result["Test - Project - Date"]).Equals(DateTime.Parse("1991-02-16", CultureInfo.InvariantCulture)));
            Assert.IsTrue(((bool)result["Test - Project - YesNo - True"]).Equals(true));
            Assert.IsTrue(((bool)result["Test - Project - YesNo - False"]).Equals(false));
        }

        [TestMethod]
        public void GetProject_ByGuid_ShouldReturnNewDataSetWithUpdatedProjectName()
        {
            var projectDataSet = _projectService.Invoke(p => p.ReadProject(Settings.DefaultProjectGuid, DataStoreEnum.WorkingStore));

            var result = new Dictionary<string, object>();
            _mapper.Map(
                projectDataSet.Project,
                result,
                new NopPropsMatcher(),
                new BasicProjectMappingProjNameToTestValueConverter());

            Assert.IsTrue(result["PROJ_NAME"].Equals("Test"));
            Assert.IsTrue(((Guid)result["PROJ_UID"]).Equals(Settings.DefaultProjectGuid));

            var newProjectDataSet = new ProjectDataSet();
            _mapper.Map(
                result,
                newProjectDataSet.Project,
                new NopPropsMatcher(),
                new BasicProjectMappingIfProjNameTestSetUpdatedValueConverter());

            Assert.IsTrue(newProjectDataSet.Project[0]["PROJ_NAME"].Equals("Updated"));
            Assert.IsTrue(((Guid)newProjectDataSet.Project[0]["PROJ_UID"]).Equals(Settings.DefaultProjectGuid));
        }
    }
}
