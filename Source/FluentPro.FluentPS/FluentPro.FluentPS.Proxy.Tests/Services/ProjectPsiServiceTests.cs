using FluentPro.FluentPS.Psi.Services;
using FluentPro.FluentPS.Psi.Tests.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

            Assert.IsTrue(projects.Count == 38);
        }

        [TestMethod]
        public void CreateProject_WithNameAndGuid_ShouldReturnTrue()
        {
            var target = new ProjectPsiService(Settings.PwaUri);
            var queue = new QueuePsiService(Settings.PwaUri);

            var result = queue.Wait(target.Create(Settings.DefaultProjectGuid, Settings.DefaultProjectName));

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetProject_ByGuid_ShouldReturnProject()
        {
            var target = new ProjectPsiService(Settings.PwaUri);

            var result = target.Get<SimpleProject>(Settings.DefaultProjectGuid);

            Assert.IsTrue(result.ProjName == Settings.DefaultProjectName);
        }

        [TestMethod]
        public void DeleteProject_ByGuid_ShouldReturnTrue()
        {
            var target = new ProjectPsiService(Settings.PwaUri);
            var queue = new QueuePsiService(Settings.PwaUri);

            var result = queue.Wait(target.Delete(Settings.DefaultProjectGuid));

            Assert.IsTrue(result);
        }
    }
}
