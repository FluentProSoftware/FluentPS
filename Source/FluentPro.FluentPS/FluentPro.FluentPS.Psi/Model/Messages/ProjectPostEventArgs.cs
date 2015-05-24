namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectPostEntitiesDeletedEventArgs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectPostUpdatedEventArgs))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class ProjectPostEventArgs : PostEventArgs {
        
        private string projectNameField;
        
        private System.Guid projectGuidField;
        
        private bool isWorkingStoreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ProjectName {
            get {
                return this.projectNameField;
            }
            set {
                this.projectNameField = value;
                this.RaisePropertyChanged("ProjectName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.Guid ProjectGuid {
            get {
                return this.projectGuidField;
            }
            set {
                this.projectGuidField = value;
                this.RaisePropertyChanged("ProjectGuid");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool IsWorkingStore {
            get {
                return this.isWorkingStoreField;
            }
            set {
                this.isWorkingStoreField = value;
                this.RaisePropertyChanged("IsWorkingStore");
            }
        }
    }
}