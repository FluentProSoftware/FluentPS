using System;
using FluentPro.FluentPS.Common.Mapper.Conventions.Naming;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentPro.FluentPS.Common.Tests.Mapper.Conventions.Naming
{
    [TestClass]
    public class DefaultNamingConventionTests
    {
        [TestMethod]
        public void GetName_WithSimpleName_ShouldReturnSimpleName()
        {
            var sut = new DefaultNamingConvention();

            var res = sut.GetName("Name");

            Assert.IsTrue(res == "Name");
        }
    }
}
