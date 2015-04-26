using FluentPro.FluentPS.Common.Mapper;
using FluentPro.FluentPS.Psi.Model.DataSets;
using FluentPro.FluentPS.Psi.Model.Enums;
using FluentPro.FluentPS.Psi.Network;
using FluentPro.FluentPS.Psi.Tests.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            var context = PsiContext.Get(Settings.PwaUri);

            var ds = context.Project.Invoke(project => project.ReadProjectList());
            var reader = ds.Project.CreateDataReader();

            var result = FluentMapper.Current.Map<DataTableReader, List<SimpleProject>>(reader);

            Assert.IsTrue(result.Count == 1);
        }

        [TestMethod]
        public void CreateProject_WithNameAndGuid_ShouldReturnTrue()
        {
            var context = PsiContext.Get(Settings.PwaUri);

            var ds = new ProjectDataSet();
            var row = ds.Project.NewProjectRow();
            row.PROJ_TYPE = (int)ProjectType.Project;
            row.PROJ_UID = Settings.DefaultProjectGuid;
            row.PROJ_NAME = Settings.DefaultProjectName;
            ds.Project.AddProjectRow(row);

            var result = context.Project
                .Invoke((service, job) => service.QueueCreateProject(job.JobUid, ds, false))
                .WaitSync();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetProject_ByGuid_ShouldReturnProjectEntity()
        {
            var context = PsiContext.Get(Settings.PwaUri);

            var dataSet = context.Project.Invoke(p => p.ReadProject(Settings.DefaultProjectGuid, DataStoreEnum.WorkingStore));
            var reader = dataSet.Project.CreateDataReader();
            reader.Read();

            var result = new SimpleProject();
            FluentMapper.Current.Map(reader, result);

            Assert.IsTrue(result.ProjName == Settings.DefaultProjectName);
        }

        [TestMethod]
        public void GetProject_ByGuid_ShouldReturnDictionary()
        {
            var context = PsiContext.Get(Settings.PwaUri);

            var dataSet = context.Project.Invoke(p => p.ReadProject(Settings.DefaultProjectGuid, DataStoreEnum.WorkingStore));
            var reader = dataSet.Project.CreateDataReader();
            reader.Read();

            var result = new Dictionary<string, object>();
            FluentMapper.Current.Map(reader, result);

            Assert.IsTrue(result["PROJ_NAME"].Equals(Settings.DefaultProjectName));
        }

        [TestMethod]
        public void GetProject_ByGuid_ShouldReturnDictionaryWithCustomFields()
        {
            var target = PsiContext.Get(Settings.PwaUri);

            var dataSet = target.Project
                .Invoke(p => p.ReadProjectEntities(
                    Settings.DefaultProjectGuid,
                    (int)(ProjectLoadType.Project | ProjectLoadType.ProjectCustomFields),
                    DataStoreEnum.WorkingStore));

            var result = new Dictionary<string, object>();

            var reader = dataSet.Project.CreateDataReader();
            reader.Read();
            FluentMapper.Current.Map(reader, result);

            var customFieldsReader = dataSet.ProjectCustomFields.CreateDataReader();
            reader.Read();
            FluentMapper.Current.Map(reader, result);


            Assert.IsTrue(result["PROJ_NAME"].Equals(Settings.DefaultProjectName));
        }

        [TestMethod]
        public void DeleteProject_ByGuid_ShouldReturnTrue()
        {
            var target = PsiContext.Get(Settings.PwaUri);

            var result = target.Project
                .Invoke((p, job) => p.QueueDeleteProjects(job.JobUid, true, new[] { Settings.DefaultProjectGuid }, true))
                .WaitSync();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PublishProject_ByGuid_ShouldReturnTrue()
        {
            var target = PsiContext.Get(Settings.PwaUri);

            var result = target.Project
                .Invoke((p, job) => p.QueuePublish(job.JobUid, Settings.DefaultProjectGuid, true, string.Empty))
                .WaitSync();

            Assert.IsTrue(result);
        }
    }
}
