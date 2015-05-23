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
using FluentPro.FluentPS.Psi.Model.Enums;

namespace FluentPro.FluentPS.Psi.Interfaces.Psi
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/Archive/", ConfigurationName="Archive")]
    public interface IArchive
    {
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueArchi" +
            "veProjects", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueArchi" +
            "veProjectsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueArchiveProjectsServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueArchiveProjectsDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void QueueArchiveProjects();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueArchi" +
            "veProject", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueArchi" +
            "veProjectResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueArchiveProjectDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueArchiveProjectServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        System.Guid QueueArchiveProject(System.Guid jobUID, System.Guid projectUID, System.Guid archivedProjectUID, string versionDescription, int retentionPolicy, bool permanentArchive);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueResto" +
            "reProject", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueResto" +
            "reProjectResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueRestoreProjectServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueRestoreProjectDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void QueueRestoreProject(System.Guid jobUID, System.Guid projectUID, System.Guid versionUID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueDelet" +
            "eArchivedProject", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueDelet" +
            "eArchivedProjectResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueDeleteArchivedProjectDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueDeleteArchivedProjectServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void QueueDeleteArchivedProject(System.Guid jobUID, System.Guid projectUID, System.Guid archiveUID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/ReadArchiv" +
            "edProjectsList", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/Archive/ReadArchiv" +
            "edProjectsListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Re" +
            "adArchivedProjectsListServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Re" +
            "adArchivedProjectsListDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        ArchivedProjectsDataSet ReadArchivedProjectsList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/ReadProjec" +
            "tArchiveRetentionSetting", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/Archive/ReadProjec" +
            "tArchiveRetentionSettingResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Re" +
            "adProjectArchiveRetentionSettingServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Re" +
            "adProjectArchiveRetentionSettingDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        ProjectArchiveRetentionDataSet ReadProjectArchiveRetentionSetting();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/ReadArchiv" +
            "eSchedule", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/Archive/ReadArchiv" +
            "eScheduleResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Re" +
            "adArchiveScheduleServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Re" +
            "adArchiveScheduleDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        ArchiveScheduleDataSet ReadArchiveSchedule();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/UpdateArch" +
            "iveSchedule", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/Archive/UpdateArch" +
            "iveScheduleResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Up" +
            "dateArchiveScheduleServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Up" +
            "dateArchiveScheduleDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void UpdateArchiveSchedule(ArchiveScheduleDataSet scheduleDataSet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueArchi" +
            "veResources", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueArchi" +
            "veResourcesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueArchiveResourcesServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueArchiveResourcesDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void QueueArchiveResources(System.Guid jobUID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueResto" +
            "reResources", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueResto" +
            "reResourcesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueRestoreResourcesServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueRestoreResourcesDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void QueueRestoreResources(System.Guid jobUID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueArchi" +
            "veCustomFields", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueArchi" +
            "veCustomFieldsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueArchiveCustomFieldsDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueArchiveCustomFieldsServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void QueueArchiveCustomFields(System.Guid jobUID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueResto" +
            "reCustomFields", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueResto" +
            "reCustomFieldsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueRestoreCustomFieldsDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueRestoreCustomFieldsServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void QueueRestoreCustomFields(System.Guid jobUID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueArchi" +
            "veSystemSettings", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueArchi" +
            "veSystemSettingsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueArchiveSystemSettingsDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueArchiveSystemSettingsServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void QueueArchiveSystemSettings(System.Guid jobUID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueResto" +
            "reSystemSettings", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueResto" +
            "reSystemSettingsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueRestoreSystemSettingsServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueRestoreSystemSettingsDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void QueueRestoreSystemSettings(System.Guid jobUID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueArchi" +
            "veCategories", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueArchi" +
            "veCategoriesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueArchiveCategoriesDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueArchiveCategoriesServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void QueueArchiveCategories(System.Guid jobUID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueResto" +
            "reCategories", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueResto" +
            "reCategoriesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueRestoreCategoriesDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueRestoreCategoriesServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void QueueRestoreCategories(System.Guid jobUID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueArchi" +
            "veViews", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueArchi" +
            "veViewsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueArchiveViewsDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueArchiveViewsServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void QueueArchiveViews(System.Guid jobUID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueResto" +
            "reViews", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueResto" +
            "reViewsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueRestoreViewsServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueRestoreViewsDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void QueueRestoreViews(System.Guid jobUID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueArchi" +
            "veGlobalProject", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueArchi" +
            "veGlobalProjectResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueArchiveGlobalProjectServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueArchiveGlobalProjectDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void QueueArchiveGlobalProject(System.Guid jobUID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueResto" +
            "reGlobalProject", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueResto" +
            "reGlobalProjectResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueRestoreGlobalProjectServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueRestoreGlobalProjectDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void QueueRestoreGlobalProject(System.Guid jobUID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueSched" +
            "uleArchives", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/Archive/QueueSched" +
            "uleArchivesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueScheduleArchivesDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/Archive/Archive/Qu" +
            "eueScheduleArchivesServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void QueueScheduleArchives(ArchiveOpcode opCode);
    }
}