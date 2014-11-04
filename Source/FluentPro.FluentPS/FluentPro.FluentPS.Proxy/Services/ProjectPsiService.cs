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

        public void QueueUpdateProjectImpacts(Guid jobUid, Guid sessionUid, DataSet projectImpactDataSet)
        {
            _psiContext.Project.QueueUpdateProjectImpacts(jobUid, sessionUid, (ProjectImpactDataSet)projectImpactDataSet);
        }

        public Guid CreateWssListSyncedProject(DataSet syncDataSet, string projectName)
        {
            return _psiContext.Project.CreateWssListSyncedProject((SyncDataSet)syncDataSet, projectName);
        }

        public void SyncProjectWithWss(Guid syncEntityUid, SyncEntityUidType syncEntityUidType)
        {
            //TODO: Fix this
            _psiContext.Project.SyncProjectWithWss(syncEntityUid, syncEntityUidType);
        }

        public DataSet ReadProjectSyncSettings(Guid[] syncEntityUids, SyncEntityUidType syncEntityUidType, bool includeMappingData)
        {
            return _psiContext.Project.ReadProjectSyncSettings(syncEntityUids, syncEntityUidType, includeMappingData);
        }

        public void UpdateProjectSyncSettings(SyncDataSet syncDataSet)
        {
            throw new NotImplementedException();
        }

        public Model.DataSets.SyncErrorsDataSet ReadProjectSyncErrorInfo(Guid wssListUid)
        {
            throw new NotImplementedException();
        }

        public string ReadServerTimelineData(Guid timelineType)
        {
            throw new NotImplementedException();
        }

        public void UpdateServerTimelineData(Guid timelineType, string tlData)
        {
            throw new NotImplementedException();
        }

        public Model.Messages.QueueImportTaskListsResponse QueueImportTaskLists(Model.Messages.QueueImportTaskListsRequest request)
        {
            throw new NotImplementedException();
        }

        public void QueueUpdateProject2(Guid jobUid, Guid sessionUid, Model.DataSets.ProjectDataSet dataset, bool validateOnly)
        {
            throw new NotImplementedException();
        }

        public void QueueUpdateVisibilityMode(Guid jobUid, Guid projectUid, Model.DataSets.ProjectDataSet dataset)
        {
            throw new NotImplementedException();
        }

        public void CheckOutProject(Guid projectUid, Guid sessionUid, string sessionDescription)
        {
            throw new NotImplementedException();
        }

        public void QueueCheckInProject(Guid jobUid, Guid projectUid, bool force, Guid sessionUid, string sessionDescription)
        {
            throw new NotImplementedException();
        }

        public void QueueCreateProject(Guid jobUid, DataSet dataset, bool validateOnly)
        {
            //TODO: Create two methods, one something like IsValid(), and the other one is Create()
            _psiContext.Project.QueueCreateProject(jobUid, (ProjectDataSet)dataset, false);
        }

        public void QueueCreateProjectAndCheckOut(Guid jobUid, Guid sessionUid, string sessionDescription, Model.DataSets.ProjectDataSet dataset, bool validateOnly)
        {
            throw new NotImplementedException();
        }

        public void QueueAddToProject(Guid jobUid, Guid sessionUid, Model.DataSets.ProjectDataSet dataset, bool validateOnly)
        {
            throw new NotImplementedException();
        }

        public Guid CreateProjectFromTemplate(Guid templateUid, string projectName)
        {
            throw new NotImplementedException();
        }

        public void QueueDeleteProjects(Guid jobUid, bool deleteWSS, Guid[] projectUids, bool deleteBoth)
        {
            throw new NotImplementedException();
        }

        public void QueueRenameProject(Guid jobUid, Guid sessionUid, Guid projectUid, string name)
        {
            throw new NotImplementedException();
        }

        public Model.DataSets.ProjectDataSet ReadProject(Guid projectUid, DataStoreEnum dataStore)
        {
            throw new NotImplementedException();
        }

        public Model.DataSets.ProjectDataSet ReadProjectEntities(Guid projectUid, int ProjectEntityType, DataStoreEnum dataStore)
        {
            throw new NotImplementedException();
        }

        public void QueueUpdateProject(Guid jobUid, Guid sessionUid, Model.DataSets.ProjectDataSet dataset, bool validateOnly)
        {
            throw new NotImplementedException();
        }

        public void QueueDeleteFromProject(Guid jobUid, Guid sessionUid, Guid projectUid, Guid[] projectEntityUids)
        {
            throw new NotImplementedException();
        }

        public Model.DataSets.ProjectTeamDataSet ReadProjectTeam(Guid projectUid)
        {
            throw new NotImplementedException();
        }

        public void QueueUpdateProjectTeam(Guid JobUid, Guid sessionUid, Guid projectUid, Model.DataSets.ProjectTeamDataSet dataset)
        {
            throw new NotImplementedException();
        }

        public Model.DataSets.ProjectContextDataSet ReadSchedulingContext(Guid[] projectUids, Guid[] resourceUids)
        {
            throw new NotImplementedException();
        }

        public string GetProjectNameFromProjectUid(Guid projectUid, DataStoreEnum dataStore)
        {
            throw new NotImplementedException();
        }

        public char ReadServerListSeparator()
        {
            throw new NotImplementedException();
        }

        public Model.DataSets.ProjectDataSet ReadProjectStatus(Guid projGuid, DataStoreEnum dataStore, string projName, int projType)
        {
            throw new NotImplementedException();
        }

        public Model.DataSets.ProjectRelationsDataSet QueuePublish(Guid jobUid, Guid projectUid, bool fullPublish, string WssURL)
        {
            throw new NotImplementedException();
        }

        public Model.DataSets.ProjectRelationsDataSet QueuePublishSummary(Guid jobUid, Guid projectUid)
        {
            throw new NotImplementedException();
        }

        public void QueueUpgradeProject(Guid projectUID)
        {
            throw new NotImplementedException();
        }

        public void QueueCreateProposalProjectAndCheckout(Guid jobUid, Guid sessionUid, string sessionDescription, Model.DataSets.ProjectDataSet projDS, bool validateOnly, bool publishProject)
        {
            throw new NotImplementedException();
        }

        public Guid CreateOperationsWorkFromWssList(Guid sessionUid, string listDataXml, string priorityMappingsXml, string projectName, string projectDescription, string titleFieldName, string startDateFieldName, string finishDateFieldName, string taskPriorityFieldName, string percentCompleteFieldName, string resourceFieldName, bool includeWorkflow)
        {
            throw new NotImplementedException();
        }

        public void UpdateProjectWorkspaceAddress(Guid projectUid, string newWebName, Guid newWSSServerUID)
        {
            throw new NotImplementedException();
        }

        Model.DataSets.ProjectDataSet IProject.ReadProjectList()
        {
            throw new NotImplementedException();
        }

        public Model.Messages.ReadProjectListByDepartmentResponse ReadProjectListByDepartment(Model.Messages.ReadProjectListByDepartmentRequest request)
        {
            throw new NotImplementedException();
        }

        public void QueueSynchronizeProjectWorkspace(Guid jobUid, Guid projectUid, bool forceFullSync)
        {
            throw new NotImplementedException();
        }

        public Model.DataSets.ProjectImpactDataSet ReadProjectImpacts(Guid projectUid, DataStoreEnum store)
        {
            throw new NotImplementedException();
        }
    }
}
