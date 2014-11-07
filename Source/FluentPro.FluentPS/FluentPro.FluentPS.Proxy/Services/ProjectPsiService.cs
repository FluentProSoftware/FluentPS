using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using FluentPro.FluentPS.Contracts.Model;
using FluentPro.FluentPS.Psi.Interfaces.Psi;
using FluentPro.FluentPS.Psi.Model.DataSets;
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

        public Guid CreateProject(string name)
        {
            //So, check in you enterprise what Custom fields (for task or project) that are flagged with "Required".
            var jobUid = Guid.NewGuid();
            var ds = new ProjectDataSet();

            var row = ds.Project.NewProjectRow();
            row.PROJ_TYPE = (int)ProjectType.Project;
            row.PROJ_UID = Guid.NewGuid();
            row.PROJ_NAME = name;
            row.ENTERPRISE_PROJECT_TYPE_UID = new Guid("09fa52b4-059b-4527-926e-99f9be96437a");
            ds.Project.AddProjectRow(row);

            _psiContext.Project.QueueCreateProject(jobUid, ds, false);
            return jobUid;
        }
    }
}
