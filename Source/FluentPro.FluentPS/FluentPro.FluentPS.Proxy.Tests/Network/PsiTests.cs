namespace FluentPro.FluentPS.Proxy.Tests.Network
{
    using FluentPro.FluentPS.Proxy.Network;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class PsiTests
    {
        [TestMethod]
        public void GetContext_WithUrl_IsNotNull()
        {
            var psi = Psi.Get(new Uri("http://udav/pwa/"));
            var list = psi.Project.ReadProjectList();
            Assert.IsNotNull(psi);
        }
    }
}
