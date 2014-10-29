using System;
using FluentPro.FluentPS.Psi.Network;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentPro.FluentPS.Psi.Tests.Network
{
    [TestClass]
    public class PsiContextTests
    {
        [TestMethod]
        public void GetContext_WithUrl_IsNotNull()
        {
            var psi = PsiContext.Get(new Uri("http://udav/pwa/"));
            Assert.IsNotNull(psi);
        }
    }
}
