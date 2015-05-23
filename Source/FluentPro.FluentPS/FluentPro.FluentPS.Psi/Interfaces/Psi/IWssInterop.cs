﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FluentPro.FluentPS.Psi.Exceptions.Faults;
using FluentPro.FluentPS.Psi.Model.DataSets;

namespace FluentPro.FluentPS.Psi.Interfaces.Psi
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/", ConfigurationName="WssInterop")]
    public interface IWssInterop
    {
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/ReadWss" +
            "ServerInfo", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/ReadWss" +
            "ServerInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/ReadWssServerInfoDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/ReadWssServerInfoServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        WssServersDataSet ReadWssServerInfo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/ReadWss" +
            "Settings", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/ReadWss" +
            "SettingsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/ReadWssSettingsServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/ReadWssSettingsDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        WssSettingsDataSet ReadWssSettings();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/UpdateW" +
            "ssSettings", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/UpdateW" +
            "ssSettingsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/UpdateWssSettingsServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/UpdateWssSettingsDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void UpdateWssSettings(WssSettingsDataSet wssSettingsDataSet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/ReadWss" +
            "Data", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/ReadWss" +
            "DataResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/ReadWssDataDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/ReadWssDataServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        ProjectWSSInfoDataSet ReadWssData(System.Guid projectUID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/GetWSSV" +
            "ServerURLs", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/GetWSSV" +
            "ServerURLsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/GetWSSVServerURLsDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/GetWSSVServerURLsServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string[] GetWSSVServerURLs();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/GetWSSV" +
            "ServerURL", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/GetWSSV" +
            "ServerURLResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/GetWSSVServerURLServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/GetWSSVServerURLDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string GetWSSVServerURL(System.Guid wssServerUID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WSSWebE" +
            "xists", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WSSWebE" +
            "xistsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/WSSWebExistsDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/WSSWebExistsServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        bool WSSWebExists(string wssWebFullUrl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/CreateW" +
            "ssSite", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/CreateW" +
            "ssSiteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/CreateWssSiteDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/CreateWssSiteServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void CreateWssSite(System.Guid projectUID, System.Guid wssServerUID, string wssWebFullUrl, int webTemplateLcid, string webTemplateName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/DeleteW" +
            "SSSite", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/DeleteW" +
            "SSSiteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/DeleteWSSSiteServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/DeleteWSSSiteDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void DeleteWSSSite(System.Guid projectUID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/QueueSy" +
            "nchronizeMembershipForWssSite", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/QueueSy" +
            "nchronizeMembershipForWssSiteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/QueueSynchronizeMembershipForWssSiteDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/QueueSynchronizeMembershipForWssSiteServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void QueueSynchronizeMembershipForWssSite(System.Guid projectUID, System.Guid jobUid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/UpdateM" +
            "embershipForWssSite", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/UpdateM" +
            "embershipForWssSiteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/UpdateMembershipForWssSiteServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/UpdateMembershipForWssSiteDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void UpdateMembershipForWssSite(System.Guid projectUID, int lastRevCounter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/Synchro" +
            "nizeMembershipForPwaAppRootSite", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/Synchro" +
            "nizeMembershipForPwaAppRootSiteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/SynchronizeMembershipForPwaAppRootSiteServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/SynchronizeMembershipForPwaAppRootSiteDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void SynchronizeMembershipForPwaAppRootSite();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/ReadPro" +
            "jectSiteBaseUrls", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/ReadPro" +
            "jectSiteBaseUrlsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/ReadProjectSiteBaseUrlsDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/ReadProjectSiteBaseUrlsServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        WssServersDataSet ReadProjectSiteBaseUrls();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/UpdateP" +
            "rojectSitePaths", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/UpdateP" +
            "rojectSitePathsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/UpdateProjectSitePathsDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/WssInterop/WssInte" +
            "rop/UpdateProjectSitePathsServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void UpdateProjectSitePaths(System.Guid oldWebAppUid, string oldSitePath, System.Guid newWebAppUid, string newSitePath, bool updateContentTypes, bool synchronizeSitePermissions);
    }
}