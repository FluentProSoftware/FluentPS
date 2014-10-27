using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentPro.FluentPS.Proxy.Exceptions.Faults
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(DefaultServerFault))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServerExecutionFault))]
    public partial class ServerFault : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string ActorField;

        private int LastErrorField;

        private string MessageField;

        private string SourceField;

        private string StackTraceField;

        private string TargetSiteField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Actor
        {
            get
            {
                return this.ActorField;
            }
            set
            {
                this.ActorField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LastError
        {
            get
            {
                return this.LastErrorField;
            }
            set
            {
                this.LastErrorField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message
        {
            get
            {
                return this.MessageField;
            }
            set
            {
                this.MessageField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Source
        {
            get
            {
                return this.SourceField;
            }
            set
            {
                this.SourceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StackTrace
        {
            get
            {
                return this.StackTraceField;
            }
            set
            {
                this.StackTraceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TargetSite
        {
            get
            {
                return this.TargetSiteField;
            }
            set
            {
                this.TargetSiteField = value;
            }
        }
    }
}
