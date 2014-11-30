using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentPro.FluentPS.Psi.Network;
using FluentPro.FluentPS.Common.DataSetAnalyzer;

namespace FluentPro.FluentPS.Psi.Tests.Services
{
    [TestClass]
    public class LookupTablePsiServiceTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ctx = PsiContext.Get(Settings.PwaUri);

            var tables = ctx.LookupTable.ReadLookupTables(string.Empty, false, 1033);
            var dsInfo = FluentDataSetAnalyzer.GetDataSetInfo(tables);
            var projects = ctx.Project.ReadProjectList();
            var projectsDsInfo = FluentDataSetAnalyzer.GetDataSetInfo(projects);
        }
    }
}
