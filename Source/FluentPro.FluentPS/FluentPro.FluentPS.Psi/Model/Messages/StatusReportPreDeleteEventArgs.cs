namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class StatusReportPreDeleteEventArgs : StatusReportPostDeleteEventArgs {
        
        private bool cancelField;
        
        private string cancelReasonField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool Cancel {
            get {
                return this.cancelField;
            }
            set {
                this.cancelField = value;
                this.RaisePropertyChanged("Cancel");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string CancelReason {
            get {
                return this.cancelReasonField;
            }
            set {
                this.cancelReasonField = value;
                this.RaisePropertyChanged("CancelReason");
            }
        }
    }
}