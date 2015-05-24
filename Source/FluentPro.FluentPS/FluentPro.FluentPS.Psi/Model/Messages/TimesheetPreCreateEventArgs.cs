using FluentPro.FluentPS.Psi.Interfaces.Psi;
using FluentPro.FluentPS.Psi.Model.DataSets;
using FluentPro.FluentPS.Psi.Model.Enums;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class TimesheetPreCreateEventArgs : PreEventArgs {
        
        private TimesheetDataSet dsDeltaField;
        
        private PreloadType preloadTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TimesheetDataSet DsDelta {
            get {
                return this.dsDeltaField;
            }
            set {
                this.dsDeltaField = value;
                this.RaisePropertyChanged("DsDelta");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public PreloadType PreloadType {
            get {
                return this.preloadTypeField;
            }
            set {
                this.preloadTypeField = value;
                this.RaisePropertyChanged("PreloadType");
            }
        }
    }
}