using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentPro.FluentPS.Contracts.Constants;
using FluentPro.FluentPS.Psi.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentPro.FluentPS.Psi.Tests.Services
{
    [TestClass]
    public class ProjectPsiServiceTests
    {
        [TestMethod]
        public void ReadProjectList_NoParams_ShouldReturnProjects()
        {
            var target = new ProjectPsiService(new Uri("http://udav/pwa/"));
            var result = target.ReadProjectList();
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Tables[DsTables.Project].Rows.Count > 0);
        }
    }
}
