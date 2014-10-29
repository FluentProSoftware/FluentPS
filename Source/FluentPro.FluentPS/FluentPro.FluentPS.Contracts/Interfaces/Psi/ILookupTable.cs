using System;
using System.ServiceModel;
using FluentPro.FluentPS.Contracts.Exceptions.Faults;
using FluentPro.FluentPS.Contracts.Model.DataSets;
using FluentPro.FluentPS.Proxy.Model.DataSets;

namespace FluentPro.FluentPS.Contracts.Interfaces.Psi
{
    [ServiceContract(Namespace = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/", ConfigurationName = "FluentPro.FluentPS.Proxy.Wcf.LookupTable")]
    public interface ILookupTable
    {
        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/CheckOutLookupTables", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/CheckOutLookupTablesResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/LookupTable/CheckOutLookupTablesDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/LookupTable/CheckOutLookupTablesServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void CheckOutLookupTables(Guid[] array);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/CheckInLookupTables", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/CheckInLookupTablesResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/LookupTable/CheckInLookupTablesServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/LookupTable/CheckInLookupTablesDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void CheckInLookupTables(Guid[] array, bool force);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/ReadLookupTablesMultiLang", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/ReadLookupTablesMultiLangResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/LookupTable/ReadLookupTablesMultiLangDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/LookupTable/ReadLookupTablesMultiLangServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        LookupTableMultiLangDataSet ReadLookupTablesMultiLang(string xmlFilter, bool autoCheckOut);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/CreateLookupTablesMultiLang", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/Create=LookupTablesMultiLangResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/LookupTable/CreateLookupTablesMultiLangServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/LookupTable/CreateLookupTablesMultiLangDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void CreateLookupTablesMultiLang(LookupTableMultiLangDataSet ltds, bool validateOnly, bool autoCheckIn);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/DeleteLookupTables", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/DeleteLookupTablesResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/LookupTable/DeleteLookupTablesDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/LookupTable/DeleteLookupTablesServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void DeleteLookupTables(Guid[] ltGuids);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/UpdateLookupTablesMultiLang", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/UpdateLookupTablesMultiLangResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/LookupTable/UpdateLookupTablesMultiLangDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/LookupTable/UpdateLookupTablesMultiLangServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void UpdateLookupTablesMultiLang(LookupTableMultiLangDataSet ltds, bool validateOnly, bool autoCheckIn);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/ReadLookupTables", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/ReadLookupTablesResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/LookupTable/ReadLookupTablesDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/LookupTable/ReadLookupTablesServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        LookupTableDataSet ReadLookupTables(string xmlFilter, bool autoCheckOut, int language);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/ReadLookupTablesByUids", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/ReadLookupTablesByUidsResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/LookupTable/ReadLookupTablesByUidsServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/LookupTable/ReadLookupTablesByUidsDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        LookupTableDataSet ReadLookupTablesByUids(Guid[] ltUidList, bool autoCheckOut, int language);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/ReadLookupTablesMultiLangByUids", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/ReadLookupTablesMultiLangByUidsResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/LookupTable/ReadLookupTablesMultiLangByUidsDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/LookupTable/ReadLookupTablesMultiLangByUidsServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        LookupTableMultiLangDataSet ReadLookupTablesMultiLangByUids(Guid[] ltUidList, bool autoCheckOut);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/CreateLookupTables", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/CreateLookupTablesResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/LookupTable/CreateLookupTablesDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/LookupTable/CreateLookupTablesServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void CreateLookupTables(LookupTableDataSet ltds, bool validateOnly, bool autoCheckIn);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/UpdateLookupTables", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/UpdateLookupTablesResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/LookupTable/UpdateLookupTablesDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/LookupTable/LookupTable/UpdateLookupTablesServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void UpdateLookupTables(LookupTableDataSet ltds, bool validateOnly, bool autoCheckIn, int language);
    }
}
