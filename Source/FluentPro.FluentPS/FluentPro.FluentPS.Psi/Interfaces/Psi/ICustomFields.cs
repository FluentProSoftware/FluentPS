﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FluentPro.FluentPS.Psi.Interfaces.Psi
{
    using FluentPro.FluentPS.Psi.Exceptions.Faults;
    using FluentPro.FluentPS.Psi.Model.DataSets;
    using System.CodeDom.Compiler;
    using System.ServiceModel;

    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [ServiceContract(Namespace = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/", ConfigurationName = "FluentPro.PsObjects.Psi.CustomFields.CustomFields")]
    public interface ICustomFields
    {
        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CheckOutCustomFields", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CheckOutCustomFieldsResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CustomFields/CheckOutCustomFieldsServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CustomFields/CheckOutCustomFieldsDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void CheckOutCustomFields(System.Guid[] array);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CheckInCustomFields", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CheckInCustomFieldsResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CustomFields/CheckInCustomFieldsServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CustomFields/CheckInCustomFieldsDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void CheckInCustomFields(System.Guid[] array, bool force);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/ReadCustomFields", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/ReadCustomFieldsResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CustomFields/ReadCustomFieldsDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CustomFields/ReadCustomFieldsServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        CustomFieldDataSet ReadCustomFields(string xmlFilter, bool autoCheckOut);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/ReadCustomFieldsByMdPropUids", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/ReadCustomFieldsByMdPropUidsResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CustomFields/ReadCustomFieldsByMdPropUidsServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CustomFields/ReadCustomFieldsByMdPropUidsDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        CustomFieldDataSet ReadCustomFieldsByMdPropUids(System.Guid[] md_prop_uids, bool autoCheckOut);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/ReadCustomFieldsByEntity", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/ReadCustomFieldsByEntityResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CustomFields/ReadCustomFieldsByEntityServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CustomFields/ReadCustomFieldsByEntityDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        CustomFieldDataSet ReadCustomFieldsByEntity(System.Guid entityUid);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CreateCustomFields", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CreateCustomFieldsResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CustomFields/CreateCustomFieldsDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CustomFields/CreateCustomFieldsServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void CreateCustomFields(CustomFieldDataSet cfds, bool validateOnly, bool autoCheckIn);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/UpdateCustomFields", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/UpdateCustomFieldsResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CustomFields/UpdateCustomFieldsDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CustomFields/UpdateCustomFieldsServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void UpdateCustomFields(CustomFieldDataSet cfds, bool validateOnly, bool autoCheckIn);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/DeleteCustomFields", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/DeleteCustomFieldsResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CustomFields/DeleteCustomFieldsServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CustomFields/DeleteCustomFieldsDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void DeleteCustomFields(System.Guid[] CustomFieldIDs);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CreateCustomFields2", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CreateCustomFields2Response")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CustomFields/CreateCustomFields2DefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CustomFields/CreateCustomFields2ServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void CreateCustomFields2(CustomFieldDataSet cfds, bool validateOnly, bool autoCheckIn);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/UpdateCustomFields2", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/UpdateCustomFields2Response")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CustomFields/UpdateCustomFields2DefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CustomFields/UpdateCustomFields2ServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void UpdateCustomFields2(CustomFieldDataSet cfds, bool validateOnly, bool autoCheckIn);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/ReadCustomFields2", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/ReadCustomFields2Response")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CustomFields/ReadCustomFields2DefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CustomFields/ReadCustomFields2ServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        CustomFieldDataSet ReadCustomFields2(string xmlFilter, bool autoCheckOut);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/ReadCustomFieldsByMdPropUids2", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/ReadCustomFieldsByMdPropUids2Response")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CustomFields/ReadCustomFieldsByMdPropUids2ServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CustomFields/ReadCustomFieldsByMdPropUids2DefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        CustomFieldDataSet ReadCustomFieldsByMdPropUids2(System.Guid[] md_prop_uids, bool autoCheckOut);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/ReadCustomFieldsByEntity2", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/ReadCustomFieldsByEntity2Response")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CustomFields/ReadCustomFieldsByEntity2ServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/CustomFields/CustomFields/ReadCustomFieldsByEntity2DefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        CustomFieldDataSet ReadCustomFieldsByEntity2(System.Guid entityUid);
    }
}