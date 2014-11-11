using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using FluentPro.FluentPS.Common.Mapper;
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

        public Guid Create(Guid projectUid, string projectName)
        {
            //So, check in you enterprise what Custom fields (for task or project) that are flagged with "Required".
            var jobUid = Guid.NewGuid();
            var ds = new ProjectDataSet();

            var row = ds.Project.NewProjectRow();
            row.PROJ_TYPE = (int)ProjectType.Project;
            row.PROJ_UID = projectUid;
            row.PROJ_NAME = projectName;
            ds.Project.AddProjectRow(row);

            _psiContext.Project.QueueCreateProject(jobUid, ds, false);
            return jobUid; 
        }

        public Guid Delete(Guid projectUid)
        {
            var jobUid = Guid.NewGuid();
            _psiContext.Project.QueueDeleteProjects(jobUid, true, new [] { projectUid }, true);
            return jobUid;
        }

        public T Get<T>(Guid projectUid)
        {
            var dataSet = _psiContext.Project.ReadProject(projectUid, DataStoreEnum.WorkingStore);
            var reader = dataSet.Project.CreateDataReader();
            reader.Read();

            return DsMapper.Map<DataTableReader, T>(reader);
        }
       
        public Guid Publish(Guid projectUid)
        {
            var jobUid = Guid.NewGuid();
            _psiContext.Project.QueuePublish(jobUid, projectUid, true, string.Empty);
            return jobUid;
        }
    }
}
