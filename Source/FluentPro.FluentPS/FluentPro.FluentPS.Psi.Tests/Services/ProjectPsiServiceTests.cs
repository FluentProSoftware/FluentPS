using FluentPro.FluentPS.Psi.Interfaces.Psi;
using FluentPro.FluentPS.Psi.Model.DataSets;
using FluentPro.FluentPS.Psi.Model.Enums;
using FluentPro.FluentPS.Psi.Network;
using FluentPro.FluentPS.Psi.Tests.Model;
using FluentPro.FluentPS.Psi.Tests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using FluentPro.Common.Mapper;
using FluentPro.Common.Mapper.Configurations;
using FluentPro.Common.Mapper.Configurations.PropertyNameConverters;
using FluentPro.FluentPS.Mapper;

namespace FluentPro.FluentPS.Psi.Tests.Services
{
    [TestClass]
    public class ProjectPsiServiceTests
    {
        [TestMethod]
        public void ReadProjectList_ShouldReturnValidCountOfProjects()
        {
            var projectService = PsiContext.Get<IProject>(Settings.PwaUri);

            var ds = projectService.Invoke(project => project.ReadProjectList());

            var mapper = new FluentMapper(new PsMappingConfiguration());

            var result = mapper.Map<DataTable, List<SimpleProject>>(ds.Project);

            Assert.IsTrue(result.Count == 1);
        }

        [TestMethod]
        public void CreateProject_WithNameAndGuid_ShouldReturnTrue()
        {
            var mapper = new FluentMapper(new PsMappingConfiguration());
            var projectService = PsiContext.Get<IProject>(Settings.PwaUri);

            var simpleProject = new SimpleProject
            {
                ProjName = Settings.DefaultProjectName,
                ProjUid = Settings.DefaultProjectGuid,
                ProjType = (int)ProjectType.Project
            };

            var ds = new ProjectDataSet();
            mapper.Map(simpleProject, ds.Project);
            //var row = ds.Project.NewProjectRow();
            //row.PROJ_TYPE = (int)ProjectType.Project;
            //row.PROJ_UID = Settings.DefaultProjectGuid;
            //row.PROJ_NAME = Settings.DefaultProjectName;
            //ds.Project.AddProjectRow(row);

            var jobUid = Guid.NewGuid();
            projectService.Invoke(p => p.QueueCreateProject(jobUid, ds, false));
            Assert.IsTrue(QueueUtil.Wait(jobUid));
        }

        [TestMethod]
        public void GetProject_ByGuid_ShouldReturnProjectEntity()
        {
            var mapper = new FluentMapper(new PsMappingConfiguration());
            var projectService = PsiContext.Get<IProject>(Settings.PwaUri);

            var dataSet = projectService.Invoke(p => p.ReadProject(Settings.DefaultProjectGuid, DataStoreEnum.WorkingStore));

            var result = new SimpleProject();
            mapper.Map(dataSet.Project, result);

            Assert.IsTrue(result.ProjName == Settings.DefaultProjectName);
        }

        [TestMethod]
        public void GetProject_ByGuid_ShouldReturnDictionary()
        {
            var mapper = new FluentMapper(new PsMappingConfiguration());
            var projectService = PsiContext.Get<IProject>(Settings.PwaUri);

            var dataSet = projectService.Invoke(p => p.ReadProject(Settings.DefaultProjectGuid, DataStoreEnum.WorkingStore));

            var result = new Dictionary<string, object>();
            mapper.Map(dataSet.Project, result, propertyNameConverter: new LeaveOriginalNamePropertyNameConverter());

            Assert.IsTrue(result["PROJ_NAME"].Equals(Settings.DefaultProjectName));
        }

        [TestMethod]
        public void GetProject_ByGuid_ShouldReturnDictionaryWithCustomFields()
        {
            var mapper = new FluentMapper(new PsMappingConfiguration());

            var projectService = PsiContext.Get<IProject>(Settings.PwaUri);
            var customFieldsService = PsiContext.Get<ICustomFields>(Settings.PwaUri);

            var projectDataSet = projectService.Invoke(p => p.ReadProjectEntities(
                    Settings.DefaultProjectGuid,
                    (int)(ProjectLoadType.Project | ProjectLoadType.ProjectCustomFields),
                    DataStoreEnum.WorkingStore));

            var customFieldsDataSet = customFieldsService.Invoke(s => s.ReadCustomFields(string.Empty, false));

            var result = new Dictionary<string, object>();

            mapper.Map(
                projectDataSet.Project,
                result,
                new LeaveOriginalNamePropertyNameConverter());

            mapper.Map(
                projectDataSet.ProjectCustomFields,
                result,
                new LeaveOriginalNamePropertyNameConverter(),
                externalData: new Dictionary<string, object> 
                {
                    { customFieldsDataSet.DataSetName, customFieldsDataSet }
                });

            Assert.IsTrue(result["PROJ_NAME"].Equals(Settings.DefaultProjectName));
            Assert.IsTrue(result["Project - Text"].Equals("10"));
        }

        [TestMethod]
        public void DeleteProject_ByGuid_ShouldReturnTrue()
        {
            var projectService = PsiContext.Get<IProject>(Settings.PwaUri);

            var jobUid = Guid.NewGuid();
            projectService.Invoke(p => p.QueueDeleteProjects(jobUid, true, new[] { Settings.DefaultProjectGuid }, true));

            Assert.IsTrue(QueueUtil.Wait(jobUid));
        }

        [TestMethod]
        public void PublishProject_ByGuid_ShouldReturnTrue()
        {
            var projectService = PsiContext.Get<IProject>(Settings.PwaUri);

            var jobUid = Guid.NewGuid();
            projectService.Invoke(p => p.QueuePublish(jobUid, Settings.DefaultProjectGuid, true, string.Empty));

            Assert.IsTrue(QueueUtil.Wait(jobUid));
        }
    }
}
