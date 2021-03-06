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
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/", ConfigurationName = "ResourcePlan")]
    public interface IResourcePlan
    {
        [System.ServiceModel.OperationContractAttribute(Action = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Check" +
            "OutResourcePlans", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Check" +
            "OutResourcePlansResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Resou" +
            "rcePlan/CheckOutResourcePlansDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Resou" +
            "rcePlan/CheckOutResourcePlansServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void CheckOutResourcePlans(System.Guid[] projectUids);

        [System.ServiceModel.OperationContractAttribute(Action = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Queue" +
            "CheckInResourcePlans", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Queue" +
            "CheckInResourcePlansResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Resou" +
            "rcePlan/QueueCheckInResourcePlansDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Resou" +
            "rcePlan/QueueCheckInResourcePlansServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void QueueCheckInResourcePlans(System.Guid[] projectUids, bool force, System.Guid[] jobUids);

        [System.ServiceModel.OperationContractAttribute(Action = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Queue" +
            "CreateResourcePlan", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Queue" +
            "CreateResourcePlanResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Resou" +
            "rcePlan/QueueCreateResourcePlanServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Resou" +
            "rcePlan/QueueCreateResourcePlanDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void QueueCreateResourcePlan(System.Guid projectUid, ResourcePlanDataSet rpds, bool timephasedFTE, bool autoCheckIn, System.Guid jobUid);

        [System.ServiceModel.OperationContractAttribute(Action = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/ReadR" +
            "esourcePlan", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/ReadR" +
            "esourcePlanResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Resou" +
            "rcePlan/ReadResourcePlanServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Resou" +
            "rcePlan/ReadResourcePlanDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        ResourcePlanDataSet ReadResourcePlan(string filter, System.Guid projectUid, System.DateTime startDate, System.DateTime endDate, short timeScale, bool timephasedFTE, bool autoCheckOut);

        [System.ServiceModel.OperationContractAttribute(Action = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Queue" +
            "UpdateResourcePlan", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Queue" +
            "UpdateResourcePlanResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Resou" +
            "rcePlan/QueueUpdateResourcePlanServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Resou" +
            "rcePlan/QueueUpdateResourcePlanDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void QueueUpdateResourcePlan(System.Guid projectUid, ResourcePlanDataSet rpds, bool timephasedFTE, bool autoCheckIn, System.Guid jobUid);

        [System.ServiceModel.OperationContractAttribute(Action = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Queue" +
            "DeleteResourcePlan", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Queue" +
            "DeleteResourcePlanResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Resou" +
            "rcePlan/QueueDeleteResourcePlanDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Resou" +
            "rcePlan/QueueDeleteResourcePlanServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void QueueDeleteResourcePlan(System.Guid[] projectUids, System.Guid[] jobUids);

        [System.ServiceModel.OperationContractAttribute(Action = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Queue" +
            "PublishResourcePlan", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Queue" +
            "PublishResourcePlanResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Resou" +
            "rcePlan/QueuePublishResourcePlanDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Resou" +
            "rcePlan/QueuePublishResourcePlanServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void QueuePublishResourcePlan(System.Guid projectUid, System.Guid jobUid);

        [System.ServiceModel.OperationContractAttribute(Action = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/ReadR" +
            "esourcePlanStatus", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/ReadR" +
            "esourcePlanStatusResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Resou" +
            "rcePlan/ReadResourcePlanStatusDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/ResourcePlan/Resou" +
            "rcePlan/ReadResourcePlanStatusServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        ResPlanStatus ReadResourcePlanStatus(System.Guid projectUid);
    }
}
