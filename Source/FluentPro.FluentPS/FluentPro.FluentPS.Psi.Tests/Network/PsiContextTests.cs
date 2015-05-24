using System;
using FluentPro.FluentPS.Psi.Network;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentPro.FluentPS.Psi.Model.Enums;
using System.Collections.Generic;
using System.ServiceModel.Security;
using FluentPro.Common.Mapper;
using FluentPro.Common.Mapper.Configurations;
using FluentPro.FluentPS.Psi.Interfaces.Psi;
using System.Text;

namespace FluentPro.FluentPS.Psi.Tests.Network
{
    [TestClass]
    public class PsiContextTests
    {
        [TestMethod]
        public void GetContext_WithUrl_IsNotNull()
        {
            var projectService = PsiContext.Get<IProject>(Settings.PwaUri);
            Assert.IsNotNull(projectService);
        }

        [TestMethod]
        [ExpectedException(typeof(MessageSecurityException))]
        public void GetContext_WithWrongUrl_ShouldThrow()
        {
            var projectService = PsiContext.Get<IProject>(Settings.WrongPwaUri);
            projectService.Invoke(p => p.ReadProjectList());
        }
    }
}
