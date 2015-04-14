using System;
using FluentPro.FluentPS.Psi.Network;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentPro.FluentPS.Common.Mapper;
using FluentPro.FluentPS.Psi.Model.Enums;
using System.Data;
using System.Collections.Generic;

namespace FluentPro.FluentPS.Psi.Tests.Network
{
    [TestClass]
    public class PsiContextTests
    {
        [TestMethod]
        public void GetContext_WithUrl_IsNotNull()
        {
            var psi = PsiContext.Get(Settings.PwaUri);
            Assert.IsNotNull(psi);
        }

        [TestMethod]
        public void GetProjectDataSet_WithCustomFields_ShouldReturnDataSet()
        {
            var psi = PsiContext.Get(Settings.PwaUri);

            var projectDataSet = psi.Project.Invoke(p => p.ReadProjectEntities(Settings.DefaultProjectGuid, (int)(ProjectLoadType.Project | ProjectLoadType.ProjectCustomFields), DataStoreEnum.WorkingStore));
            var nativeFieldsReader = projectDataSet.Project.CreateDataReader();
            nativeFieldsReader.Read();

            var customFieldsReader = projectDataSet.ProjectCustomFields.CreateDataReader();
            customFieldsReader.Read();

            var dict = new Dictionary<string, object>();
            FluentMapper.PsMapper.Map(nativeFieldsReader, dict);
            FluentMapper.PsMapper.Map(projectDataSet.ProjectCustomFields, dict);

            Assert.IsTrue(dict["PROJ_NAME"].Equals(Settings.DefaultProjectName));
        }
    }
}
