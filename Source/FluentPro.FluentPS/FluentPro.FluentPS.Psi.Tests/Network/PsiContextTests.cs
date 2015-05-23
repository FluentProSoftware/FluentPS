using FluentPro.FluentPS.Psi.Network;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentPro.FluentPS.Psi.Model.Enums;
using System.Collections.Generic;
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

        [Ignore]
        [TestMethod]
        public void Helper_DumpNativeFieldsToString()
        {
            var projectService = PsiContext.Get<IProject>(Settings.PwaUri);
            var viewService = PsiContext.Get<>()

            var viewDataSet = 

            //var projectDataSet =
            //    projectService.Invoke(p => p.ReadProject(Settings.DefaultProjectGuid, DataStoreEnum.WorkingStore));

            //var sb = new StringBuilder();
            //foreach (var col in projectDataSet.Project.Columns)
            //{
            //    //FieldInfo(PsDataType psEntiType, string name, PsDataType psDataType, Type type)
            //    sb.AppendFormat("new FieldInfo(PsDataType.Project, \"{0}\",  ")
            //}
        }
    }
}
