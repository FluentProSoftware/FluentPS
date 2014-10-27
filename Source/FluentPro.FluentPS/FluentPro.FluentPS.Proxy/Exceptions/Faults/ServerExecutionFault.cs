using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentPro.FluentPS.Proxy.Exceptions.Faults
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
    public partial class ServerExecutionFault : DefaultServerFault
    {

        private System.Xml.XmlElement ExceptionDetailsField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Xml.XmlElement ExceptionDetails
        {
            get
            {
                return this.ExceptionDetailsField;
            }
            set
            {
                this.ExceptionDetailsField = value;
            }
        }
    }
}
