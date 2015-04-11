using FluentPro.FluentPS.Common.Mapper;
using FluentPro.FluentPS.Psi.Model.DataSets;
using FluentPro.FluentPS.Psi.Model.Enums;
using FluentPro.FluentPS.Psi.Model.Project;
using FluentPro.FluentPS.Psi.Network;
using FluentPro.FluentPS.Psi.Types;
using System;
using System.Collections.Generic;
using System.Data;

namespace FluentPro.FluentPS.Psi.Services
{
    public class ProjectPsiService
    {
        private readonly Uri _pwaUri;
        private readonly PsiContext _psiContext;

        public ProjectPsiService(Uri pwaUri)
        {
            _pwaUri = pwaUri;
            _psiContext = PsiContext.Get(pwaUri);
        }

        public List<ProjectBasicInfo> GetProjectsBasicInfo()
        {
            var ds = _psiContext.Project.Invoke(project => project.ReadProjectList());
            var reader = ds.Project.CreateDataReader();

            var result = FluentMapper.PsMapper.Map<DataTableReader, List<ProjectBasicInfo>>(reader);
            return result;
        }

        public QueueJob Create(Guid projectUid, string projectName)
        {
            //So, check in you enterprise what Custom fields (for task or project) that are flagged with "Required".            
            var ds = new ProjectDataSet();

            var row = ds.Project.NewProjectRow();
            row.PROJ_TYPE = (int)ProjectType.Project;
            row.PROJ_UID = projectUid;
            row.PROJ_NAME = projectName;
            ds.Project.AddProjectRow(row);

            var job = new QueueJob(_pwaUri);
            _psiContext.Project.Invoke(p => p.QueueCreateProject(job.JobUid, ds, false));
            return job;
        }

        public QueueJob Delete(Guid projectUid)
        {
            var job = new QueueJob(_pwaUri);
            _psiContext.Project.Invoke(p => p.QueueDeleteProjects(job.JobUid, true, new[] { projectUid }, true));
            return job;
        }

        public T Get<T>(Guid projectUid)
        {
            var dataSet = _psiContext.Project.Invoke(p => p.ReadProject(projectUid, DataStoreEnum.WorkingStore));
            var reader = dataSet.Project.CreateDataReader();
            reader.Read();

            return FluentMapper.PsMapper.Map<DataTableReader, T>(reader);
        }

        public QueueJob Publish(Guid projectUid)
        {
            var job = new QueueJob(_pwaUri);
            _psiContext.Project.Invoke(p => p.QueuePublish(job.JobUid, projectUid, true, string.Empty));
            return job;
        }
    }
}
