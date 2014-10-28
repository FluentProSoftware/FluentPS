using System.Diagnostics;
using System.Runtime.Serialization;
using System.Xml;

namespace FluentPro.FluentPS.Contracts.Exceptions.Faults
{
    [DebuggerStepThrough]
    [DataContract(Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
    public partial class ServerExecutionFault : DefaultServerFault
    {
        [DataMember]
        public XmlElement ExceptionDetails { get; set; }
    }
}
