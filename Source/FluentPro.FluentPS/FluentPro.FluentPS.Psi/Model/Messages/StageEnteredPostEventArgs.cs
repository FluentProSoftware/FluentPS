namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class StageEnteredPostEventArgs : PostEventArgs {
        
        private System.Guid projectUidField;
        
        private System.Guid workflowInstanceUidField;
        
        private System.Guid previousStageUidField;
        
        private System.Guid currentStageUidField;
        
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
        public System.Guid PreviousStageUid {
            get {
                return this.previousStageUidField;
            }
            set {
                this.previousStageUidField = value;
                this.RaisePropertyChanged("PreviousStageUid");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public System.Guid CurrentStageUid {
            get {
                return this.currentStageUidField;
            }
            set {
                this.currentStageUidField = value;
                this.RaisePropertyChanged("CurrentStageUid");
            }
        }
    }
}