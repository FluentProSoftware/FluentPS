using FluentPro.FluentPS.Psi.Interfaces.Psi;
using FluentPro.FluentPS.Psi.Model.DataSets;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class TimesheetPreUpdateEventArgs : PreEventArgs {
        
        private System.Guid tsUIDField;
        
        private System.Guid resUIDField;
        
        private TimesheetDataSet dsDeltaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid TsUID {
            get {
                return this.tsUIDField;
            }
            set {
                this.tsUIDField = value;
                this.RaisePropertyChanged("TsUID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.Guid ResUID {
            get {
                return this.resUIDField;
            }
            set {
                this.resUIDField = value;
                this.RaisePropertyChanged("ResUID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public TimesheetDataSet DsDelta {
            get {
                return this.dsDeltaField;
            }
            set {
                this.dsDeltaField = value;
                this.RaisePropertyChanged("DsDelta");
            }
        }
    }
}