using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using FluentPro.FluentPS.Contracts.Model;
using FluentPro.FluentPS.Psi.Model.Enums;
using FluentPro.FluentPS.Psi.Network;

namespace FluentPro.FluentPS.Psi.Services
{
    public class ProjectPsiService
    {
        private readonly PsiContext _psiContext;

        public ProjectPsiService(Uri pwaUri)
        {
            _psiContext = PsiContext.Get(pwaUri);
        }

        public DataSet ReadProjectList()
        {
            return _psiContext.Project.ReadProjectList();
        }

        public DataSet ReadProject(Guid projecUid, DataStore dataStore)
        {
            return _psiContext.Project.ReadProject(projecUid, (DataStoreEnum)dataStore);
        }
    }
}
