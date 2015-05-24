using FluentPro.FluentPS.Psi.Model.Enums;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class PcsWorkerStatusData : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int pidField;
        
        private System.Guid workerIdField;
        
        private System.Guid projectIdField;
        
        private System.Guid siteIdField;
        
        private string siteUrlField;
        
        private PcsWorkerStatus statusField;
        
        private string serverNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Pid {
            get {
                return this.pidField;
            }
            set {
                this.pidField = value;
                this.RaisePropertyChanged("Pid");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.Guid WorkerId {
            get {
                return this.workerIdField;
            }
            set {
                this.workerIdField = value;
                this.RaisePropertyChanged("WorkerId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public System.Guid ProjectId {
            get {
                return this.projectIdField;
            }
            set {
                this.projectIdField = value;
                this.RaisePropertyChanged("ProjectId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public PcsWorkerStatus Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
                this.RaisePropertyChanged("Status");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
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