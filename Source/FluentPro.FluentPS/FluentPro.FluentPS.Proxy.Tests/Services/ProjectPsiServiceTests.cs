using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentPro.FluentPS.Contracts.Constants;
using FluentPro.FluentPS.Psi.Services;
using FluentPro.FluentPS.Psi.Tests.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentPro.FluentPS.Psi.Tests.Services
{
    [TestClass]
    public class ProjectPsiServiceTests
    {
        [TestMethod]
        public void CreateProject_WithNameAndGuid_ShouldReturnJobUid()
        {
            var target = new ProjectPsiService(Settings.PwaUri);

            var result = target.Create(Settings.DefaultProjectGuid, Settings.DefaultProjectName);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetProject_ByGuid_ShouldReturnProject()
        {
            var target = new ProjectPsiService(Settings.PwaUri);

            var result = target.Get<SimpleProject>(Settings.DefaultProjectGuid);

            Assert.IsTrue(result.ProjName == Settings.DefaultProjectName);
        }

        [TestMethod]
        public void DeleteProject_ByGuid_ShouldReturnJobUid()
        {

        }
    }
}
