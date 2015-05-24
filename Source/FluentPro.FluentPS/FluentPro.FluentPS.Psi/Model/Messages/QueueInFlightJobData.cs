using FluentPro.FluentPS.Psi.Model.Enums;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class QueueInFlightJobData : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Guid jobIdField;
        
        private QueueMsgType messageTypeField;
        
        private JobState jobStateField;
        
        private System.Guid siteIdField;
        
        private string siteUrlField;
        
        private string serverNameField;
        
        private System.DateTime queueEntryTimeField;
        
        private System.DateTime queuePickupTimeField;
        
        private double jobWaitTimeField;
        
        private double jobProcessingDurationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid JobId {
            get {
                return this.jobIdField;
            }
            set {
                this.jobIdField = value;
                this.RaisePropertyChanged("JobId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public QueueMsgType MessageType {
            get {
                return this.messageTypeField;
            }
            set {
                this.messageTypeField = value;
                this.RaisePropertyChanged("MessageType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public JobState JobState {
            get {
                return this.jobStateField;
            }
            set {
                this.jobStateField = value;
                this.RaisePropertyChanged("JobState");
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
        public string ServerName {
            get {
                return this.serverNameField;
            }
            set {
                this.serverNameField = value;
                this.RaisePropertyChanged("ServerName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public System.DateTime QueueEntryTime {
            get {
                return this.queueEntryTimeField;
            }
            set {
                this.queueEntryTimeField = value;
                this.RaisePropertyChanged("QueueEntryTime");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public System.DateTime QueuePickupTime {
            get {
                return this.queuePickupTimeField;
            }
            set {
                this.queuePickupTimeField = value;
                this.RaisePropertyChanged("QueuePickupTime");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public double JobWaitTime {
            get {
                return this.jobWaitTimeField;
            }
            set {
                this.jobWaitTimeField = value;
                this.RaisePropertyChanged("JobWaitTime");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public double JobProcessingDuration {
            get {
                return this.jobProcessingDurationField;
            }
            set {
                this.jobProcessingDurationField = value;
                this.RaisePropertyChanged("JobProcessingDuration");
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