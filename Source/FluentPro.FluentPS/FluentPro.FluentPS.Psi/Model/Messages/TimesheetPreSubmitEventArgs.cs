namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class TimesheetPreSubmitEventArgs : PreEventArgs {
        
        private System.Guid tsUIDField;
        
        private System.Guid approverUIDField;
        
        private string commentField;
        
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
        public System.Guid ApproverUID {
            get {
                return this.approverUIDField;
            }
            set {
                this.approverUIDField = value;
                this.RaisePropertyChanged("ApproverUID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
                this.RaisePropertyChanged("Comment");
            }
        }
    }
}