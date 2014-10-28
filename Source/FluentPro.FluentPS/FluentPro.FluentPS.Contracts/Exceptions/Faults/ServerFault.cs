using System.Diagnostics;
using System.Runtime.Serialization;

namespace FluentPro.FluentPS.Contracts.Exceptions.Faults
{
    [DebuggerStepThrough]
    [DataContract(Name = "ServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
    [KnownType(typeof(DefaultServerFault))]
    [KnownType(typeof(ServerExecutionFault))]
    public partial class ServerFault : object, IExtensibleDataObject
    {
        public ExtensionDataObject ExtensionData { get; set; }

        [DataMember]
        public string Actor { get; set; }

        [DataMember]
        public int LastError { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string Source { get; set; }

        [DataMember]
        public string StackTrace { get; set; }

        [DataMember]
        public string TargetSite { get; set; }
    }
}
