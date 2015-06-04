using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading;
using FluentPro.Common.Mapper;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Attributes;
using FluentPro.FluentPS.Extensions;
using FluentPro.FluentPS.Mapper;
using FluentPro.FluentPS.Model;
using FluentPro.FluentPS.Psi.Interfaces.Psi;
using FluentPro.FluentPS.Psi.Model.DataSets;
using FluentPro.FluentPS.Psi.Model.Enums;
using FluentPro.FluentPS.Psi.Model.Messages;
using FluentPro.FluentPS.Psi.Network;
using FluentPro.FluentPS.Psi.Network.Types;

namespace FluentPro.FluentPS.Psi.Tests.Utils
{
    public class EnvUtil
    {
        private readonly IFluentMapper _mapper;
        private readonly PsiService<IProject> _projectPsiService;
        private readonly PsiService<IStatusing> _statusingPsiService; 
        private readonly PsiService<IResource> _resourcePsiService; 
        private readonly PsiService<ICustomFields> _customFieldsPsiService;
        private readonly PsiService<IQueueSystem> _queuePsiService;

        public EnvUtil(Uri pwaUri)
        {
            _mapper = new FluentMapper(new PsMappingConfiguration());
            _projectPsiService = PsiContext.Get<IProject>(pwaUri);
            _statusingPsiService = PsiContext.Get<IStatusing>(pwaUri);
            _resourcePsiService = PsiContext.Get<IResource>(pwaUri);
            _customFieldsPsiService = PsiContext.Get<ICustomFields>(pwaUri);
            _queuePsiService = PsiContext.Get<IQueueSystem>(pwaUri);
        }

        public void CreateProject<T>(T project)
        {
            var customFieldsDataSet = _customFieldsPsiService.Invoke(s => s.ReadCustomFieldsByEntity2(PsEntityType.Project.GetAttr<GuidAttribute>().Guid));
           
            var ds = new ProjectDataSet();
            _mapper.Map(project, ds.Project);
            _mapper.Map(project, ds.ProjectCustomFields, externalData: new Dictionary<string, object>
            {
                { customFieldsDataSet.DataSetName, customFieldsDataSet },
                { "PROJ_UID", ds.Project[0].PROJ_UID}
            });

            var createProjectJobUid = Guid.NewGuid();
            _projectPsiService.Invoke(p => p.QueueCreateProject(createProjectJobUid, ds, false));
            Wait(createProjectJobUid);

            var publishProjectJobUid = Guid.NewGuid();
            _projectPsiService.Invoke(p => p.QueuePublish(publishProjectJobUid, ds.Project[0].PROJ_UID, true, string.Empty));
            Wait(publishProjectJobUid);
        }

        public void DeleteProject(Guid projectGuid)
        {
            try
            {
                _statusingPsiService.Invoke(s => s.DeleteStatusingInformationForProject(new[] { projectGuid }, DateTime.MinValue, DateTime.MaxValue));
            }
            catch { }

            try
            {
                var checkInProjectJobUid = Guid.NewGuid();
                _projectPsiService.Invoke(p => p.QueueCheckInProject(checkInProjectJobUid, projectGuid, true, Settings.DefaultSessionGuid, "Unit tests session"));
                Wait(checkInProjectJobUid);
            }
            catch { }

            try
            {
                var deleteProjectJobUid = Guid.NewGuid();
                _projectPsiService.Invoke(p => p.QueueDeleteProjects(deleteProjectJobUid, true, new[] { projectGuid }, true));
                Wait(deleteProjectJobUid);
            }
            catch { }
        }

        public void CreateCustomFields<T>(List<T> customFields)
        {
            var cfds = new CustomFieldDataSet();
            _mapper.Map(customFields, cfds.CustomFields);
            _customFieldsPsiService.Invoke(c => c.CreateCustomFields2(cfds, false, true));
        }

        public void DeleteCustomFields(string mask)
        {
            try
            {
                var customFields = _customFieldsPsiService.Invoke(s => s.ReadCustomFields(string.Empty, false));

                var toDelete = customFields
                    .CustomFields
                    .Cast<CustomFieldDataSet.CustomFieldsRow>()
                    .Where(r => r.MD_PROP_NAME.StartsWith(mask))
                    .ToList();

                var toCheckout = toDelete
                    .Where(r => r.IsMD_PROP_CHECKOUTBYNull())
                    .Select(r => r.MD_PROP_UID)
                    .ToArray();

                _customFieldsPsiService.Invoke(s => s.CheckOutCustomFields(toCheckout));
                _customFieldsPsiService.Invoke(s => s.DeleteCustomFields(toDelete.Select(f => f.MD_PROP_UID).ToArray()));
            }
            catch { }
        }

        public void DeleteResources(string mask)
        {
            try
            {
                var resources = _resourcePsiService.Invoke(s => s.ReadResources("", false));

                var toDelete = resources.Resources
                    .Cast<ResourceDataSet.ResourcesRow>()
                    .Where(r => r.RES_NAME.StartsWith(mask))
                    .ToList();

                var toCheckout = toDelete
                    .Where(r => r.IsRES_CHECKOUTBYNull())
                    .Select(r => r.RES_UID)
                    .ToArray();

                _resourcePsiService.Invoke(s => s.CheckOutResources(toCheckout));

                var deleteResourceJobUid = Guid.NewGuid();
                _resourcePsiService.Invoke(s => s.DeleteResources(toDelete.Select(r => r.RES_UID).ToArray(), "Removed by unit tests"));
                Wait(deleteResourceJobUid);
            }
            catch { }
        }

        public bool Wait(Guid jobUid)
        {
            while (true)
            {
                var response = _queuePsiService.Invoke(q => q.GetJobCompletionState(new GetJobCompletionStateRequest(jobUid)));
                var jobState = response.GetJobCompletionStateResult;
                if (jobState == JobState.Success)
                {
                    return true;
                }

                if (IsJobEndedAsFailed(jobState))
                {
                    return false;
                }

                var aproxSecondsRemaining = _queuePsiService.Invoke(q => q.GetJobWaitTime(jobUid));
                Thread.Sleep(aproxSecondsRemaining * 1000);
            }
        }

        private static bool IsJobEndedAsFailed(JobState jobState)
        {
            return jobState == JobState.Unknown
                || jobState == JobState.Failed
                || jobState == JobState.FailedNotBlocking
                || jobState == JobState.CorrelationBlocked
                || jobState == JobState.Canceled;
        }
    }
}
