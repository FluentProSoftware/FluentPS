namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class ProjectTypeChangingEventArgs : PreEventArgs {
        
        private System.Guid projectUidField;
        
        private System.Guid currentWorkflowInstanceUidField;
        
        private System.Guid currentEnterpriseProjectTypeUidField;
        
        private System.Guid newEnterpriseProjectTypeUidField;
        
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
        public System.Guid CurrentWorkflowInstanceUid {
            get {
                return this.currentWorkflowInstanceUidField;
            }
            set {
                this.currentWorkflowInstanceUidField = value;
                this.RaisePropertyChanged("CurrentWorkflowInstanceUid");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public System.Guid CurrentEnterpriseProjectTypeUid {
            get {
                return this.currentEnterpriseProjectTypeUidField;
            }
            set {
                this.currentEnterpriseProjectTypeUidField = value;
                this.RaisePropertyChanged("CurrentEnterpriseProjectTypeUid");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public System.Guid NewEnterpriseProjectTypeUid {
            get {
                return this.newEnterpriseProjectTypeUidField;
            }
            set {
                this.newEnterpriseProjectTypeUidField = value;
                this.RaisePropertyChanged("NewEnterpriseProjectTypeUid");
            }
        }
    }
}