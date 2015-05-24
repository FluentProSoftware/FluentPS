namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class CompletedPostEventArgs : PostEventArgs {
        
        private System.Guid projectUidField;
        
        private System.Guid workflowInstanceUidField;
        
        private System.Guid lastStageUidField;
        
        private int workflowCompletionStatusField;
        
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
        public System.Guid WorkflowInstanceUid {
            get {
                return this.workflowInstanceUidField;
            }
            set {
                this.workflowInstanceUidField = value;
                this.RaisePropertyChanged("WorkflowInstanceUid");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public System.Guid LastStageUid {
            get {
                return this.lastStageUidField;
            }
            set {
                this.lastStageUidField = value;
                this.RaisePropertyChanged("LastStageUid");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int WorkflowCompletionStatus {
            get {
                return this.workflowCompletionStatusField;
            }
            set {
                this.workflowCompletionStatusField = value;
                this.RaisePropertyChanged("WorkflowCompletionStatus");
            }
        }
    }
}