using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using FluentPro.FluentPS.Psi.Network;

namespace FluentPro.FluentPS.Psi.Wrappers
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
    }
}
