namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class QueueServiceInternalStateData : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameField;
        
        private int countField;
        
        private System.Guid siteIdField;
        
        private string siteUrlField;
        
        private string projectDbNameField;
        
        private string serverNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
                this.RaisePropertyChanged("Count");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public System.Guid SiteId {
            get {
                return this.siteIdField;
            }
            set {
                this.siteIdField = value;
                this.RaisePropertyChanged("SiteId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string SiteUrl {
            get {
                return this.siteUrlField;
            }
            set {
                this.siteUrlField = value;
                this.RaisePropertyChanged("SiteUrl");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string ProjectDbName {
            get {
                return this.projectDbNameField;
            }
            set {
                this.projectDbNameField = value;
                this.RaisePropertyChanged("ProjectDbName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string ServerName {
            get {
                return this.serverNameField;
            }
            set {
                this.serverNameField = value;
                this.RaisePropertyChanged("ServerName");
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