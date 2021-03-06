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
using FluentPro.FluentPS.Psi.Model.Messages;

namespace FluentPro.FluentPS.Psi.Interfaces.Psi
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/", ConfigurationName="CubeAdmin")]
    public interface ICubeAdmin
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/SetCubeB" +
            "uildingSettings", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/SetCubeB" +
            "uildingSettingsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/SetCubeBuildingSettingsServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/SetCubeBuildingSettingsDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        int SetCubeBuildingSettings(
                    System.Guid asCubeUID, 
                    string ASServerName, 
                    string ASDBName, 
                    string ASDatabaseDescription, 
                    string ASExtraNetAddress, 
                    int dateRangeChoice, 
                    int pastNum, 
                    int pastUnit, 
                    int nextNum, 
                    int nextUnit, 
                    System.DateTime FromDate, 
                    System.DateTime ToDate, 
                    int updateFreqChoice, 
                    int freqNumber, 
                    int freqUnit, 
                    System.DateTime startDate, 
                    int startTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/QueueCBS" +
            "Request", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/QueueCBS" +
            "RequestResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/QueueCBSRequestDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/QueueCBSRequestServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        System.Guid QueueCBSRequest(CBSRequestMessage settingcbsMsg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/ReadCube" +
            "FieldSettings", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/ReadCube" +
            "FieldSettingsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/ReadCubeFieldSettingsServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/ReadCubeFieldSettingsDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        CubeFieldSettingDataSet ReadCubeFieldSettings();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/UpdateCu" +
            "beCalculatedMemberDefintion", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/UpdateCu" +
            "beCalculatedMemberDefintionResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/UpdateCubeCalculatedMemberDefintionServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/UpdateCubeCalculatedMemberDefintionDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void UpdateCubeCalculatedMemberDefintion(CubeCalculatedMemberDataSet calculatedMembersDataset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/UpdateCu" +
            "beFieldSettingForDimension", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/UpdateCu" +
            "beFieldSettingForDimensionResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/UpdateCubeFieldSettingForDimensionServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/UpdateCubeFieldSettingForDimensionDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void UpdateCubeFieldSettingForDimension(System.Guid[] Dim_Project_PropUID_Add, System.Guid[] Dim_Project_PropUID_Del, System.Guid[] Dim_Resource_PropUID_Add, System.Guid[] Dim_Resource_PropUID_Del, System.Guid[] Dim_Task_PropUID_Add, System.Guid[] Dim_Task_PropUID_Del, System.Guid[] Dim_Assignment_PropUID_Add, System.Guid[] Dim_Assignment_PropUID_Del);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/UpdateCu" +
            "beFieldSettingForMeasure", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/UpdateCu" +
            "beFieldSettingForMeasureResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/UpdateCubeFieldSettingForMeasureServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/UpdateCubeFieldSettingForMeasureDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void UpdateCubeFieldSettingForMeasure(System.Guid[] Measure_Project_PropUID_Add, System.Guid[] Measure_Project_PropUID_Del, System.Guid[] Measure_Resource_PropUID_Add, System.Guid[] Measure_Resource_PropUID_Del, System.Guid[] Measure_Task_PropUID_Add, System.Guid[] Measure_Task_PropUID_Del, System.Guid[] Measure_Assignment_PropUID_Add, System.Guid[] Measure_Assignment_PropUID_Del);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/ReadCalc" +
            "ulatedMemberDefinitions", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/ReadCalc" +
            "ulatedMemberDefinitionsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/ReadCalculatedMemberDefinitionsDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/ReadCalculatedMemberDefinitionsServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        CubeCalculatedMemberDataSet ReadCalculatedMemberDefinitions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/UpdateOl" +
            "apDatabaseSettings", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/UpdateOl" +
            "apDatabaseSettingsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/UpdateOlapDatabaseSettingsServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/UpdateOlapDatabaseSettingsDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void UpdateOlapDatabaseSettings(System.Guid olapDatabaseGuidCube, CubeSettingsDataSet cubeSettings);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CreateOl" +
            "apDatabase", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CreateOl" +
            "apDatabaseResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/CreateOlapDatabaseServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/CreateOlapDatabaseDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void CreateOlapDatabase(System.Guid olapDatabaseGuidCube, CubeSettingsDataSet cubeSettings);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/ReadOlap" +
            "DatabaseSetting", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/ReadOlap" +
            "DatabaseSettingResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/ReadOlapDatabaseSettingDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/ReadOlapDatabaseSettingServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        CubeSettingsDataSet ReadOlapDatabaseSetting(System.Guid olapDatabaseGuid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/ReadOlap" +
            "DatabaseSettingList", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/ReadOlap" +
            "DatabaseSettingListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/ReadOlapDatabaseSettingListServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/ReadOlapDatabaseSettingListDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        CubeSettingsDataSet ReadOlapDatabaseSettingList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/DeleteOl" +
            "apDatabaseSetting", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/DeleteOl" +
            "apDatabaseSettingResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/DeleteOlapDatabaseSettingServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/DeleteOlapDatabaseSettingDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void DeleteOlapDatabaseSetting(System.Guid olapDatabaseGuid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/GetDefau" +
            "ltOlapDatabase", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/GetDefau" +
            "ltOlapDatabaseResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/GetDefaultOlapDatabaseServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/GetDefaultOlapDatabaseDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        System.Guid GetDefaultOlapDatabase();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/SetDefau" +
            "ltOlapDatabase", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/SetDefau" +
            "ltOlapDatabaseResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/SetDefaultOlapDatabaseServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/SetDefaultOlapDatabaseDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void SetDefaultOlapDatabase(System.Guid olapDatabaseGuid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/SetOlapD" +
            "atabaseEnabled", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/SetOlapD" +
            "atabaseEnabledResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/SetOlapDatabaseEnabledServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/SetOlapDatabaseEnabledDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void SetOlapDatabaseEnabled(System.Guid olapDatabaseGuid, bool isEnabled);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/BuildOla" +
            "pDatabase", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/BuildOla" +
            "pDatabaseResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/BuildOlapDatabaseServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/BuildOlapDatabaseDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        System.Guid BuildOlapDatabase(System.Guid olapDatabaseGuid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/UpdateCu" +
            "beCalculatedMemberDefinition", ReplyAction="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/UpdateCu" +
            "beCalculatedMemberDefinitionResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/UpdateCubeCalculatedMemberDefinitionServerExecutionFaultFault", Name="ServerExecutionFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/CubeAdmi" +
            "n/UpdateCubeCalculatedMemberDefinitionDefaultServerFaultFault", Name="DefaultServerFault", Namespace="http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void UpdateCubeCalculatedMemberDefinition(CubeCalculatedMemberDataSet calculatedMembersDataset);
    }
}
