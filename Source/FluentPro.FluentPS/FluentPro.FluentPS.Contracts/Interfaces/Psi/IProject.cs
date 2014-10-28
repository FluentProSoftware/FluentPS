using System;
using FluentPro.FluentPS.Contracts.Exceptions.Faults;
using System.ServiceModel;
using FluentPro.FluentPS.Contracts.Model.DataSets;
using FluentPro.FluentPS.Contracts.Model.Enums;
using FluentPro.FluentPS.Contracts.Model.Messages;

namespace FluentPro.FluentPS.Contracts.Interfaces.Psi
{
    [ServiceContract(Namespace = "http://schemas.microsoft.com/office/project/server/webservices/Project/", ConfigurationName = "FluentPro.FluentPS.Proxy.Wcf.Project")]
    public interface IProject
    {
        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueUpdateProjectImpacts", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueUpdateProjectImpactsResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueUpdateProjectImpactsDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/QueueUpdateProjectImpactsServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueUpdateProjectImpacts(System.Guid jobUid, System.Guid sessionUid, ProjectImpactDataSet projectImpactDataSet);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/CreateWssL" +
            "istSyncedProject", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/CreateWssL" +
            "istSyncedProjectResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Cr" +
            "eateWssListSyncedProjectDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Cr" +
            "eateWssListSyncedProjectServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        System.Guid CreateWssListSyncedProject(SyncDataSet syncDataSet, string projectName);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/SyncProjec" +
            "tWithWss", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/SyncProjec" +
            "tWithWssResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Sy" +
            "ncProjectWithWssServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Sy" +
            "ncProjectWithWssDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void SyncProjectWithWss(System.Guid syncEntityUid, SyncEntityUidType syncEntityUidType);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjec" +
            "tSyncSettings", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjec" +
            "tSyncSettingsResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Re" +
            "adProjectSyncSettingsDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Re" +
            "adProjectSyncSettingsServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        FluentPro.FluentPS.Proxy.Wcf.SyncDataSet ReadProjectSyncSettings(System.Guid[] syncEntityUids, SyncEntityUidType syncEntityUidType, bool includeMappingData);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/UpdateProj" +
            "ectSyncSettings", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/UpdateProj" +
            "ectSyncSettingsResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Up" +
            "dateProjectSyncSettingsServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Up" +
            "dateProjectSyncSettingsDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void UpdateProjectSyncSettings(SyncDataSet syncDataSet);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjec" +
            "tSyncErrorInfo", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjec" +
            "tSyncErrorInfoResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Re" +
            "adProjectSyncErrorInfoDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Re" +
            "adProjectSyncErrorInfoServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        SyncErrorsDataSet ReadProjectSyncErrorInfo(System.Guid wssListUid);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadServer" +
            "TimelineData", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadServer" +
            "TimelineDataResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Re" +
            "adServerTimelineDataServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Re" +
            "adServerTimelineDataDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        string ReadServerTimelineData(System.Guid timelineType);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/UpdateServ" +
            "erTimelineData", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/UpdateServ" +
            "erTimelineDataResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Up" +
            "dateServerTimelineDataServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Up" +
            "dateServerTimelineDataDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void UpdateServerTimelineData(System.Guid timelineType, string tlData);

        // CODEGEN: Parameter 'QueueImportTaskListsResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'XmlArrayItem'.
        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueImpor" +
            "tTaskLists", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueImpor" +
            "tTaskListsResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueImportTaskListsServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueImportTaskListsDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        QueueImportTaskListsResponse QueueImportTaskLists(QueueImportTaskListsRequest request);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueUpdat" +
            "eProject2", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueUpdat" +
            "eProject2Response")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueUpdateProject2DefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueUpdateProject2ServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueUpdateProject2(System.Guid jobUid, System.Guid sessionUid, ProjectDataSet dataset, bool validateOnly);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueUpdat" +
            "eVisibilityMode", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueUpdat" +
            "eVisibilityModeResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueUpdateVisibilityModeDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueUpdateVisibilityModeServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueUpdateVisibilityMode(System.Guid jobUid, System.Guid projectUid, ProjectDataSet dataset);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/CheckOutPr" +
            "oject", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/CheckOutPr" +
            "ojectResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Ch" +
            "eckOutProjectServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Ch" +
            "eckOutProjectDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void CheckOutProject(System.Guid projectUid, System.Guid sessionUid, string sessionDescription);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueCheck" +
            "InProject", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueCheck" +
            "InProjectResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueCheckInProjectDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueCheckInProjectServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueCheckInProject(System.Guid jobUid, System.Guid projectUid, bool force, Guid sessionUid, string sessionDescription);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueCreat" +
            "eProject", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueCreat" +
            "eProjectResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueCreateProjectServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueCreateProjectDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueCreateProject(System.Guid jobUid, ProjectDataSet dataset, bool validateOnly);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueCreat" +
            "eProjectAndCheckOut", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueCreat" +
            "eProjectAndCheckOutResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueCreateProjectAndCheckOutServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueCreateProjectAndCheckOutDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueCreateProjectAndCheckOut(Guid jobUid, Guid sessionUid, string sessionDescription, ProjectDataSet dataset, bool validateOnly);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueAddTo" +
            "Project", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueAddTo" +
            "ProjectResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueAddToProjectServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueAddToProjectDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueAddToProject(Guid jobUid, Guid sessionUid, ProjectDataSet dataset, bool validateOnly);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/CreateProj" +
            "ectFromTemplate", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/CreateProj" +
            "ectFromTemplateResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Cr" +
            "eateProjectFromTemplateServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Cr" +
            "eateProjectFromTemplateDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        Guid CreateProjectFromTemplate(Guid templateUid, string projectName);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueDelet" +
            "eProjects", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueDelet" +
            "eProjectsResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueDeleteProjectsServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueDeleteProjectsDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueDeleteProjects(Guid jobUid, bool deleteWSS, Guid[] projectUids, bool deleteBoth);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueRenam" +
            "eProject", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueRenam" +
            "eProjectResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueRenameProjectServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueRenameProjectDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueRenameProject(Guid jobUid, Guid sessionUid, Guid projectUid, string name);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjec" +
            "t", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjec" +
            "tResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Re" +
            "adProjectDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Re" +
            "adProjectServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        ProjectDataSet ReadProject(Guid projectUid, DataStoreEnum dataStore);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjec" +
            "tEntities", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjec" +
            "tEntitiesResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Re" +
            "adProjectEntitiesServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Re" +
            "adProjectEntitiesDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        ProjectDataSet ReadProjectEntities(Guid projectUid, int ProjectEntityType, DataStoreEnum dataStore);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueUpdat" +
            "eProject", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueUpdat" +
            "eProjectResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueUpdateProjectDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueUpdateProjectServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueUpdateProject(Guid jobUid, Guid sessionUid, FluentPro.FluentPS.Proxy.Wcf.ProjectDataSet dataset, bool validateOnly);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueDelet" +
            "eFromProject", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueDelet" +
            "eFromProjectResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueDeleteFromProjectServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueDeleteFromProjectDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueDeleteFromProject(System.Guid jobUid, System.Guid sessionUid, System.Guid projectUid, System.Guid[] projectEntityUids);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjec" +
            "tTeam", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjec" +
            "tTeamResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Re" +
            "adProjectTeamDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Re" +
            "adProjectTeamServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        FluentPro.FluentPS.Proxy.Wcf.ProjectTeamDataSet ReadProjectTeam(System.Guid projectUid);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueUpdat" +
            "eProjectTeam", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueUpdat" +
            "eProjectTeamResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueUpdateProjectTeamServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueUpdateProjectTeamDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueUpdateProjectTeam(System.Guid JobUid, System.Guid sessionUid, System.Guid projectUid, FluentPro.FluentPS.Proxy.Wcf.ProjectTeamDataSet dataset);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadSchedu" +
            "lingContext", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadSchedu" +
            "lingContextResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Re" +
            "adSchedulingContextServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Re" +
            "adSchedulingContextDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        FluentPro.FluentPS.Proxy.Wcf.ProjectContextDataSet ReadSchedulingContext(System.Guid[] projectUids, System.Guid[] resourceUids);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/GetProject" +
            "NameFromProjectUid", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/GetProject" +
            "NameFromProjectUidResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Ge" +
            "tProjectNameFromProjectUidDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Ge" +
            "tProjectNameFromProjectUidServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        string GetProjectNameFromProjectUid(System.Guid projectUid, FluentPro.FluentPS.Proxy.Wcf.DataStoreEnum dataStore);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadServer" +
            "ListSeparator", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadServer" +
            "ListSeparatorResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Re" +
            "adServerListSeparatorDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Re" +
            "adServerListSeparatorServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        char ReadServerListSeparator();

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjec" +
            "tStatus", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjec" +
            "tStatusResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Re" +
            "adProjectStatusDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Re" +
            "adProjectStatusServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        FluentPro.FluentPS.Proxy.Wcf.ProjectDataSet ReadProjectStatus(System.Guid projGuid, FluentPro.FluentPS.Proxy.Wcf.DataStoreEnum dataStore, string projName, int projType);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueuePubli" +
            "sh", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueuePubli" +
            "shResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "euePublishDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "euePublishServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        FluentPro.FluentPS.Proxy.Wcf.ProjectRelationsDataSet QueuePublish(System.Guid jobUid, System.Guid projectUid, bool fullPublish, string WssURL);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueuePubli" +
            "shSummary", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueuePubli" +
            "shSummaryResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "euePublishSummaryDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "euePublishSummaryServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        FluentPro.FluentPS.Proxy.Wcf.ProjectRelationsDataSet QueuePublishSummary(System.Guid jobUid, System.Guid projectUid);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueUpgra" +
            "deProject", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueUpgra" +
            "deProjectResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueUpgradeProjectServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueUpgradeProjectDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueUpgradeProject(System.Guid projectUID);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueCreat" +
            "eProposalProjectAndCheckout", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueCreat" +
            "eProposalProjectAndCheckoutResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueCreateProposalProjectAndCheckoutServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueCreateProposalProjectAndCheckoutDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueCreateProposalProjectAndCheckout(System.Guid jobUid, System.Guid sessionUid, string sessionDescription, FluentPro.FluentPS.Proxy.Wcf.ProjectDataSet projDS, bool validateOnly, bool publishProject);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/CreateOper" +
            "ationsWorkFromWssList", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/CreateOper" +
            "ationsWorkFromWssListResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Cr" +
            "eateOperationsWorkFromWssListDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Cr" +
            "eateOperationsWorkFromWssListServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        System.Guid CreateOperationsWorkFromWssList(System.Guid sessionUid, string listDataXml, string priorityMappingsXml, string projectName, string projectDescription, string titleFieldName, string startDateFieldName, string finishDateFieldName, string taskPriorityFieldName, string percentCompleteFieldName, string resourceFieldName, bool includeWorkflow);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/UpdateProj" +
            "ectWorkspaceAddress", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/UpdateProj" +
            "ectWorkspaceAddressResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Up" +
            "dateProjectWorkspaceAddressServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Up" +
            "dateProjectWorkspaceAddressDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void UpdateProjectWorkspaceAddress(System.Guid projectUid, string newWebName, System.Guid newWSSServerUID);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjec" +
            "tList", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjec" +
            "tListResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Re" +
            "adProjectListDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Re" +
            "adProjectListServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        FluentPro.FluentPS.Proxy.Wcf.ProjectDataSet ReadProjectList();

        // CODEGEN: Parameter 'departmentUid' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'XmlElement'.
        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjec" +
            "tListByDepartment", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjec" +
            "tListByDepartmentResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Re" +
            "adProjectListByDepartmentServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Re" +
            "adProjectListByDepartmentDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        FluentPro.FluentPS.Proxy.Wcf.ReadProjectListByDepartmentResponse ReadProjectListByDepartment(FluentPro.FluentPS.Proxy.Wcf.ReadProjectListByDepartmentRequest request);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueSynch" +
            "ronizeProjectWorkspace", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/QueueSynch" +
            "ronizeProjectWorkspaceResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueSynchronizeProjectWorkspaceDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Qu" +
            "eueSynchronizeProjectWorkspaceServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void QueueSynchronizeProjectWorkspace(System.Guid jobUid, System.Guid projectUid, bool forceFullSync);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjec" +
            "tImpacts", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/Project/ReadProjec" +
            "tImpactsResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Re" +
            "adProjectImpactsDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/Project/Project/Re" +
            "adProjectImpactsServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        ProjectImpactDataSet ReadProjectImpacts(System.Guid projectUid, FluentPro.FluentPS.Proxy.Wcf.DataStoreEnum store);

    }

}
