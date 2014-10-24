using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentPro.FluentPS.Proxy.Network;
using FluentPro.FluentPS.Proxy.Services;

namespace FluentPro.FluentPS.Proxy.Tests
{
    [TestClass]
    public class PsiChannelFactoryTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var list = new ProjectWcfService().ReadProjectList();
        }
    }
}
