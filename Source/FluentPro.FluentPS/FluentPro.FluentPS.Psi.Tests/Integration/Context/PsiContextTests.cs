using System.ServiceModel.Security;
using FluentPro.FluentPS.Psi.Interfaces.Psi;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentPro.FluentPS.Psi.Tests.Integration.Context
{
    [TestClass]
    public class PsiContextTests
    {
        [TestMethod]
        public void GetContext_WithUrl_IsNotNull()
        {
            var projectService = Network.PsiContext.Get<IProject>(Settings.PwaUri);
            Assert.IsNotNull(projectService);
        }

        [TestMethod]
        [ExpectedException(typeof(MessageSecurityException))]
        public void GetContext_WithWrongUrl_ShouldThrow()
        {
            var projectService = Network.PsiContext.Get<IProject>(Settings.WrongPwaUri);
            projectService.Invoke(p => p.ReadProjectList());
        }
    }
}
