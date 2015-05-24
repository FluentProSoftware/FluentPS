using FluentPro.FluentPS.Psi.Model.Enums;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class ProjectDrillDownInfo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool hasPermissionField;
        
        private WorkflowState workflowStateField;
        
        private bool hasCurrentStageField;
        
        private string pdpUrlField;
        
        private string projectWorkspaceUrlField;
        
        private bool isInVisibilityModeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool HasPermission {
            get {
                return this.hasPermissionField;
            }
            set {
                this.hasPermissionField = value;
                this.RaisePropertyChanged("HasPermission");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public WorkflowState WorkflowState {
            get {
                return this.workflowStateField;
            }
            set {
                this.workflowStateField = value;
                this.RaisePropertyChanged("WorkflowState");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool HasCurrentStage {
            get {
                return this.hasCurrentStageField;
            }
            set {
                this.hasCurrentStageField = value;
                this.RaisePropertyChanged("HasCurrentStage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string PdpUrl {
            get {
                return this.pdpUrlField;
            }
            set {
                this.pdpUrlField = value;
                this.RaisePropertyChanged("PdpUrl");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string ProjectWorkspaceUrl {
            get {
                return this.projectWorkspaceUrlField;
            }
            set {
                this.projectWorkspaceUrlField = value;
                this.RaisePropertyChanged("ProjectWorkspaceUrl");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool IsInVisibilityMode {
            get {
                return this.isInVisibilityModeField;
            }
            set {
                this.isInVisibilityModeField = value;
                this.RaisePropertyChanged("IsInVisibilityMode");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}