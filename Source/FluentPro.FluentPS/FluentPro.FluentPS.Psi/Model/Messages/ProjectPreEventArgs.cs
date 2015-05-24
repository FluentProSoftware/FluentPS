using FluentPro.FluentPS.Psi.Model.DataSets;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectPreEntitiesDeletingEventArgs))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class ProjectPreEventArgs : PreEventArgs {
        
        private string projectNameField;
        
        private System.Guid projectGuidField;
        
        private ProjectDataSet projectDataSetField;
        
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
        public ProjectDataSet ProjectDataSet {
            get {
                return this.projectDataSetField;
            }
            set {
                this.projectDataSetField = value;
                this.RaisePropertyChanged("ProjectDataSet");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
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