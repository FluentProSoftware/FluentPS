namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class TimesheetPreRecallEventArgs : PreEventArgs {
        
        private System.Guid tsUIDField;
        
        private System.Guid resUIDField;
        
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
    }
}