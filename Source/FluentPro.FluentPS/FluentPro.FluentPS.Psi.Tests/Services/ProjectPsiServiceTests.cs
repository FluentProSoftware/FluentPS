using FluentPro.FluentPS.Psi.Model.Enums;
using FluentPro.FluentPS.Psi.Services;
using FluentPro.FluentPS.Psi.Tests.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FluentPro.FluentPS.Psi.Tests.Services
{
    [TestClass]
    public class ProjectPsiServiceTests
    {
        [TestMethod]
        public void ReadProjectList_ShouldReturnValidCountOfProjects()
        {
            var target = new ProjectPsiService(Settings.PwaUri);

            var projects = target.GetProjectsBasicInfo();

            Assert.IsTrue(projects.Count == 1);
        }

        [TestMethod]
        public void CreateProject_WithNameAndGuid_ShouldReturnTrue()
        {
            var target = new ProjectPsiService(Settings.PwaUri);

            var result = target.Create(Settings.DefaultProjectGuid, Settings.DefaultProjectName).WaitSync();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetProject_ByGuid_ShouldReturnProjectEntity()
        {
            var target = new ProjectPsiService(Settings.PwaUri);

            var result = target.Get<SimpleProject>(Settings.DefaultProjectGuid);

            Assert.IsTrue(result.ProjName == Settings.DefaultProjectName);
        }

        [TestMethod]
        public void GetProject_ByGuid_ShouldReturnDictionary()
        {
            var target = new ProjectPsiService(Settings.PwaUri);

            var result = target.Get<Dictionary<string, object>>(Settings.DefaultProjectGuid);

            Assert.IsTrue(result["PROJ_NAME"].Equals(Settings.DefaultProjectName));
        }

        [TestMethod]
        public void GetProject_ByGuid_ShouldReturnDictionaryWithCustomFields()
        {
            var target = new ProjectPsiService(Settings.PwaUri);

            var result = target.Get<Dictionary<string, object>>(
                Settings.DefaultProjectGuid, 
                ProjectLoadType.Project | ProjectLoadType.ProjectCustomFields);

            Assert.IsTrue(result["PROJ_NAME"].Equals(Settings.DefaultProjectName));
        }

        [TestMethod]
        public void DeleteProject_ByGuid_ShouldReturnTrue()
        {
            var target = new ProjectPsiService(Settings.PwaUri);

            var result = target.Delete(Settings.DefaultProjectGuid).WaitSync();

            Assert.IsTrue(result);
        }
    }
}
