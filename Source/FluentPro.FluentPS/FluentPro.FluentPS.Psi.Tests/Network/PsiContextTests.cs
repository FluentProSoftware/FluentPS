using FluentPro.FluentPS.Psi.Network;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentPro.FluentPS.Psi.Model.Enums;
using System.Collections.Generic;
using FluentPro.Common.Mapper;
using FluentPro.Common.Mapper.Configurations;
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
            var mapper = new FluentMapper(new DefaultMappingConfiguration());

            var projectService = PsiContext.Get<IProject>(Settings.PwaUri);

            var projectDataSet = projectService.Invoke(p => p.ReadProjectEntities(Settings.DefaultProjectGuid, (int)(ProjectLoadType.Project | ProjectLoadType.ProjectCustomFields), DataStoreEnum.WorkingStore));

            var dict = new Dictionary<string, object>();
            mapper.Map(projectDataSet.Project, dict);
            mapper.Map(projectDataSet.ProjectCustomFields, dict);

            Assert.IsTrue(dict["PROJ_NAME"].Equals(Settings.DefaultProjectName));
        }
    }
}
