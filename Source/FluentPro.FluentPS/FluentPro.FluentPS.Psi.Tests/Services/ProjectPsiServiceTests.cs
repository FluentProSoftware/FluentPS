using FluentPro.FluentPS.Common.Mapper;
using FluentPro.FluentPS.Common.Mapper.Configurations.PropertyNameConverters;
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

            var result = FluentMapper.Current.Map<DataTable, List<SimpleProject>>(ds.Project);

            Assert.IsTrue(result.Count == 1);
        }

        [TestMethod]
        public void CreateProject_WithNameAndGuid_ShouldReturnTrue()
        {
            var projectService = PsiContext.Get<IProject>(Settings.PwaUri);

            var ds = new ProjectDataSet();
            var row = ds.Project.NewProjectRow();
            row.PROJ_TYPE = (int)ProjectType.Project;
            row.PROJ_UID = Settings.DefaultProjectGuid;
            row.PROJ_NAME = Settings.DefaultProjectName;
            ds.Project.AddProjectRow(row);

            var jobUid = Guid.NewGuid();
            projectService.Invoke(p => p.QueueCreateProject(jobUid, ds, false));
            Assert.IsTrue(QueueUtil.Wait(jobUid));
        }

        [TestMethod]
        public void GetProject_ByGuid_ShouldReturnProjectEntity()
        {
            var projectService = PsiContext.Get<IProject>(Settings.PwaUri);

            var dataSet = projectService.Invoke(p => p.ReadProject(Settings.DefaultProjectGuid, DataStoreEnum.WorkingStore));
            var reader = dataSet.Project.CreateDataReader();
            reader.Read();

            var result = new SimpleProject();
            FluentMapper.Current.Map(reader, result);

            Assert.IsTrue(result.ProjName == Settings.DefaultProjectName);
        }

        [TestMethod]
        public void GetProject_ByGuid_ShouldReturnDictionary()
        {
            var projectService = PsiContext.Get<IProject>(Settings.PwaUri);

            var dataSet = projectService.Invoke(p => p.ReadProject(Settings.DefaultProjectGuid, DataStoreEnum.WorkingStore));

            var result = new Dictionary<string, object>();
            FluentMapper.Current.Map(dataSet.Project, result, propertyNameConverter: new LeaveOriginalNamePropertyNameConverter());

            Assert.IsTrue(result["PROJ_NAME"].Equals(Settings.DefaultProjectName));
        }

        [TestMethod]
        public void GetProject_ByGuid_ShouldReturnDictionary_Async()
        {
            var projectService = PsiContext.Get<IProject>(Settings.PwaUri);

            var dataSet = projectService.Invoke(p => p.ReadProject(Settings.DefaultProjectGuid, DataStoreEnum.WorkingStore));

            var result = new Dictionary<string, object>();
            FluentMapper.Current.Map(dataSet.Project, result, propertyNameConverter: new LeaveOriginalNamePropertyNameConverter());

            Assert.IsTrue(result["PROJ_NAME"].Equals(Settings.DefaultProjectName));
        }

        [TestMethod]
        public void GetProject_ByGuid_ShouldReturnDictionaryWithCustomFields()
        {
            var projectService = PsiContext.Get<IProject>(Settings.PwaUri);

            var dataSet = projectService.Invoke(p => p.ReadProjectEntities(
                    Settings.DefaultProjectGuid,
                    (int)(ProjectLoadType.Project | ProjectLoadType.ProjectCustomFields),
                    DataStoreEnum.WorkingStore));

            var result = new Dictionary<string, object>();

            FluentMapper.Current.Map(dataSet.Project, result, propertyNameConverter: new LeaveOriginalNamePropertyNameConverter());
            // FluentMapper.Current.Map(dataSet.ProjectCustomFields, result);

            Assert.IsTrue(result["PROJ_NAME"].Equals(Settings.DefaultProjectName));
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
