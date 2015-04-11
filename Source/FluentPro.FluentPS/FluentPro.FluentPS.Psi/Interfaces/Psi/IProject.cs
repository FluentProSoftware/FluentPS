using System;
using System.ServiceModel;
using FluentPro.FluentPS.Psi.Exceptions.Faults;
using FluentPro.FluentPS.Psi.Model.DataSets;
using FluentPro.FluentPS.Psi.Model.Enums;
using FluentPro.FluentPS.Psi.Model.Messages;

namespace FluentPro.FluentPS.Psi.Interfaces.Psi
{
    [ServiceContract(Namespace = "http://schemas.microsoft.com/office/project/server/webservices/Project/", ConfigurationName = "FluentPro.FluentPS.Proxy.Wcf.Project")]
    public interface IProject
    {
        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueUpdateProjectImpacts", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueUpdateProjectImpactsResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueUpdateProjectImpactsDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueUpdateProjectImpactsServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueUpdateProjectImpacts(Guid jobUid, Guid sessionUid, ProjectImpactDataSet projectImpactDataSet);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/CreateWssListSyncedProject", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/CreateWssListSyncedProjectResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/CreateWssListSyncedProjectDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/CreateWssListSyncedProjectServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        Guid CreateWssListSyncedProject(SyncDataSet syncDataSet, string projectName);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/SyncProjectWithWss", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/SyncProjectWithWssResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/SyncProjectWithWssServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/SyncProjectWithWssDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void SyncProjectWithWss(Guid syncEntityUid, SyncEntityUidType syncEntityUidType);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjectSyncSettings", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjectSyncSettingsResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/ReadProjectSyncSettingsDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/ReadProjectSyncSettingsServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        SyncDataSet ReadProjectSyncSettings(Guid[] syncEntityUids, SyncEntityUidType syncEntityUidType, bool includeMappingData);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/UpdateProjectSyncSettings", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/UpdateProjectSyncSettingsResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/UpdateProjectSyncSettingsServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/UpdateProjectSyncSettingsDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void UpdateProjectSyncSettings(SyncDataSet syncDataSet);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjectSyncErrorInfo", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjectSyncErrorInfoResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/ReadProjectSyncErrorInfoDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/ReadProjectSyncErrorInfoServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        SyncErrorsDataSet ReadProjectSyncErrorInfo(Guid wssListUid);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadServerTimelineData", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadServerTimelineDataResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/ReadServerTimelineDataServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/ReadServerTimelineDataDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        string ReadServerTimelineData(Guid timelineType);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/UpdateServerTimelineData", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/UpdateServerTimelineDataResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/UpdateServerTimelineDataServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/UpdateServerTimelineDataDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void UpdateServerTimelineData(Guid timelineType, string tlData);

        // CODEGEN: Parameter 'QueueImportTaskListsResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'XmlArrayItem'.
        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueImportTaskLists", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueImportTaskListsResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueImportTaskListsServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueImportTaskListsDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        QueueImportTaskListsResponse QueueImportTaskLists(QueueImportTaskListsRequest request);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueUpdateProject2", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueUpdateProject2Response")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueUpdateProject2DefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueUpdateProject2ServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueUpdateProject2(Guid jobUid, Guid sessionUid, ProjectDataSet dataset, bool validateOnly);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueUpdateVisibilityMode", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueUpdateVisibilityModeResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueUpdateVisibilityModeDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueUpdateVisibilityModeServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueUpdateVisibilityMode(Guid jobUid, Guid projectUid, ProjectDataSet dataset);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/CheckOutProject", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/CheckOutProjectResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/CheckOutProjectServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/CheckOutProjectDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void CheckOutProject(Guid projectUid, Guid sessionUid, string sessionDescription);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueCheckInProject", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueCheckInProjectResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueCheckInProjectDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueCheckInProjectServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueCheckInProject(Guid jobUid, Guid projectUid, bool force, Guid sessionUid, string sessionDescription);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueCreateProject", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueCreateProjectResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueCreateProjectServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueCreateProjectDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueCreateProject(Guid jobUid, ProjectDataSet dataset, bool validateOnly);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueCreateProjectAndCheckOut", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueCreateProjectAndCheckOutResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueCreateProjectAndCheckOutServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueCreateProjectAndCheckOutDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueCreateProjectAndCheckOut(Guid jobUid, Guid sessionUid, string sessionDescription, ProjectDataSet dataset, bool validateOnly);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueAddToProject", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueAddToProjectResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueAddToProjectServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueAddToProjectDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueAddToProject(Guid jobUid, Guid sessionUid, ProjectDataSet dataset, bool validateOnly);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/CreateProjectFromTemplate", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/CreateProjectFromTemplateResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/CreateProjectFromTemplateServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/CreateProjectFromTemplateDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        Guid CreateProjectFromTemplate(Guid templateUid, string projectName);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueDeleteProjects", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueDeleteProjectsResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueDeleteProjectsServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueDeleteProjectsDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueDeleteProjects(Guid jobUid, bool deleteWSS, Guid[] projectUids, bool deleteBoth);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueRenameProject", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueRenameProjectResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueRenameProjectServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueRenameProjectDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueRenameProject(Guid jobUid, Guid sessionUid, Guid projectUid, string name);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProject", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjectResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/ReadProjectDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/ReadProjectServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        ProjectDataSet ReadProject(Guid projectUid, DataStoreEnum dataStore);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjectEntities", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjectEntitiesResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/ReadProjectEntitiesServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/ReadProjectEntitiesDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        ProjectDataSet ReadProjectEntities(Guid projectUid, int ProjectEntityType, DataStoreEnum dataStore);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueUpdateProject", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueUpdateProjectResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueUpdateProjectDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueUpdateProjectServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueUpdateProject(Guid jobUid, Guid sessionUid, ProjectDataSet dataset, bool validateOnly);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueDeleteFromProject", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueDeleteFromProjectResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueDeleteFromProjectServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueDeleteFromProjectDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueDeleteFromProject(Guid jobUid, Guid sessionUid, Guid projectUid, Guid[] projectEntityUids);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjectTeam", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjectTeamResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/ReadProjectTeamDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/ReadProjectTeamServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        ProjectTeamDataSet ReadProjectTeam(Guid projectUid);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueUpdateProjectTeam", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueUpdateProjectTeamResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueUpdateProjectTeamServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueUpdateProjectTeamDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueUpdateProjectTeam(Guid JobUid, Guid sessionUid, Guid projectUid, ProjectTeamDataSet dataset);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadSchedulingContext", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadSchedulingContextResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/ReadSchedulingContextServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/ReadSchedulingContextDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        ProjectContextDataSet ReadSchedulingContext(Guid[] projectUids, Guid[] resourceUids);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/GetProjectNameFromProjectUid", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/GetProjectNameFromProjectUidResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/GetProjectNameFromProjectUidDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/GetProjectNameFromProjectUidServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        string GetProjectNameFromProjectUid(Guid projectUid, DataStoreEnum dataStore);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadServerListSeparator", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadServerListSeparatorResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/ReadServerListSeparatorDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/ReadServerListSeparatorServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        char ReadServerListSeparator();

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjectStatus", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjectStatusResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/ReadProjectStatusDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/ReadProjectStatusServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        ProjectDataSet ReadProjectStatus(Guid projGuid, DataStoreEnum dataStore, string projName, int projType);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueuePublish", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueuePublishResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueuePublishDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueuePublishServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        ProjectRelationsDataSet QueuePublish(Guid jobUid, Guid projectUid, bool fullPublish, string WssURL);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueuePublishSummary", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueuePublishSummaryResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueuePublishSummaryDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueuePublishSummaryServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        ProjectRelationsDataSet QueuePublishSummary(Guid jobUid, Guid projectUid);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueUpgradeProject", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueUpgradeProjectResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueUpgradeProjectServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueUpgradeProjectDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueUpgradeProject(Guid projectUID);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueCreateProposalProjectAndCheckout", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueCreateProposalProjectAndCheckoutResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueCreateProposalProjectAndCheckoutServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueCreateProposalProjectAndCheckoutDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueCreateProposalProjectAndCheckout(Guid jobUid, Guid sessionUid, string sessionDescription, ProjectDataSet projDS, bool validateOnly, bool publishProject);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/CreateOperationsWorkFromWssList", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/CreateOperationsWorkFromWssListResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/CreateOperationsWorkFromWssListDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/CreateOperationsWorkFromWssListServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        Guid CreateOperationsWorkFromWssList(Guid sessionUid, string listDataXml, string priorityMappingsXml, string projectName, string projectDescription, string titleFieldName, string startDateFieldName, string finishDateFieldName, string taskPriorityFieldName, string percentCompleteFieldName, string resourceFieldName, bool includeWorkflow);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/UpdateProjectWorkspaceAddress", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/UpdateProjectWorkspaceAddressResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/UpdateProjectWorkspaceAddressServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/UpdateProjectWorkspaceAddressDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void UpdateProjectWorkspaceAddress(Guid projectUid, string newWebName, Guid newWSSServerUID);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjectList", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjectListResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/ReadProjectListDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/ReadProjectListServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        ProjectDataSet ReadProjectList();

        // CODEGEN: Parameter 'departmentUid' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'XmlElement'.
        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjectListByDepartment", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjectListByDepartmentResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/ReadProjectListByDepartmentServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/ReadProjectListByDepartmentDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        ReadProjectListByDepartmentResponse ReadProjectListByDepartment(ReadProjectListByDepartmentRequest request);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueSynchronizeProjectWorkspace", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueSynchronizeProjectWorkspaceResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueSynchronizeProjectWorkspaceDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueSynchronizeProjectWorkspaceServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueSynchronizeProjectWorkspace(Guid jobUid, Guid projectUid, bool forceFullSync);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjectImpacts", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjectImpactsResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/ReadProjectImpactsDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/ReadProjectImpactsServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        ProjectImpactDataSet ReadProjectImpacts(Guid projectUid, DataStoreEnum store);
    }
}
