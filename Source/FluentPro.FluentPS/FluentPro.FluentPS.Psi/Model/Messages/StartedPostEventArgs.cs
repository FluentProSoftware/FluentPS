namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class StartedPostEventArgs : PostEventArgs {
        
        private System.Guid projectUidField;
        
        private System.Guid enterpriseProjectTypeUidField;
        
        private System.Guid workflowInstanceUidField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid ProjectUid {
            get {
                return this.projectUidField;
            }
            set {
                this.projectUidField = value;
                this.RaisePropertyChanged("ProjectUid");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.Guid EnterpriseProjectTypeUid {
            get {
                return this.enterpriseProjectTypeUidField;
            }
            set {
                this.enterpriseProjectTypeUidField = value;
                this.RaisePropertyChanged("EnterpriseProjectTypeUid");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public System.Guid WorkflowInstanceUid {
            get {
                return this.workflowInstanceUidField;
            }
            set {
                this.workflowInstanceUidField = value;
                this.RaisePropertyChanged("WorkflowInstanceUid");
            }
        }
    }
}