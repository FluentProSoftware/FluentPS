using System.Diagnostics;
using System.Runtime.Serialization;

namespace FluentPro.FluentPS.Contracts.Exceptions.Faults
{
    [DebuggerStepThrough]
    [DataContract(Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
    [KnownType(typeof(ServerExecutionFault))]
    public partial class DefaultServerFault : ServerFault
    {
    }
}
