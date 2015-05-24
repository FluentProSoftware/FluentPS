namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatusReportPreDeleteEventArgs))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class StatusReportPostDeleteEventArgs : PostEventArgs {
        
        private int whenSentField;
        
        private System.DateTime olderThanDateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int whenSent {
            get {
                return this.whenSentField;
            }
            set {
                this.whenSentField = value;
                this.RaisePropertyChanged("whenSent");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.DateTime olderThanDate {
            get {
                return this.olderThanDateField;
            }
            set {
                this.olderThanDateField = value;
                this.RaisePropertyChanged("olderThanDate");
            }
        }
    }
}