using System;
using FluentPro.FluentPS.Psi.Network;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentPro.FluentPS.Common.Mapper;
using FluentPro.FluentPS.Psi.Model.Enums;
using System.Data;
using System.Collections.Generic;
using FluentPro.FluentPS.Psi.Interfaces.Psi;

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
        public void GetProjectDataSet_WithCustomFields_ShouldReturnDataSet()
        {
            var projectService = PsiContext.Get<IProject>(Settings.PwaUri);

            var projectDataSet = projectService.Invoke(p => p.ReadProjectEntities(Settings.DefaultProjectGuid, (int)(ProjectLoadType.Project | ProjectLoadType.ProjectCustomFields), DataStoreEnum.WorkingStore));
 
            var dict = new Dictionary<string, object>();
            FluentMapper.Current.Map(projectDataSet.Project, dict);
            FluentMapper.Current.Map(projectDataSet.ProjectCustomFields, dict);

            Assert.IsTrue(dict["PROJ_NAME"].Equals(Settings.DefaultProjectName));
        }
    }
}
