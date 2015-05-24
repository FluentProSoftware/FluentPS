namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class ProjectPrePublishEventArgs : PreEventArgs {
        
        private string projectNameField;
        
        private System.Guid projectGuidField;
        
        private string wssUrlField;
        
        private System.Guid jobGuidField;
        
        private bool fullPublishField;
        
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
        public string WssUrl {
            get {
                return this.wssUrlField;
            }
            set {
                this.wssUrlField = value;
                this.RaisePropertyChanged("WssUrl");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public System.Guid JobGuid {
            get {
                return this.jobGuidField;
            }
            set {
                this.jobGuidField = value;
                this.RaisePropertyChanged("JobGuid");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool FullPublish {
            get {
                return this.fullPublishField;
            }
            set {
                this.fullPublishField = value;
                this.RaisePropertyChanged("FullPublish");
            }
        }
    }
}