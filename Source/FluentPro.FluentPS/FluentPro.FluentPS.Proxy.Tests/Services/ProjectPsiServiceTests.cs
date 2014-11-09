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
        public void CreateProject_WithName_ShouldReturnJobUid()
        {
            var target = new ProjectPsiService(Settings.PwaUri);
            var result = target.Create(Settings.DefaultProjectName);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Get_NoParams_ShouldReturnProject()
        {
            var target = new ProjectPsiService(Settings.PwaUri);
            var result = target.Get<SimpleProject>(new Guid("f5915800-ba86-4759-a7f7-98fac5b02a3c"));
            Assert.IsTrue(result.ProjName == Settings.DefaultProjectName);
        }
    }
}
