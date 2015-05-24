namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class ExistingAssignmentInfo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Guid assignmentUidField;
        
        private int lastProjectRevisionField;
        
        private int lastStatusingRevisionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid AssignmentUid {
            get {
                return this.assignmentUidField;
            }
            set {
                this.assignmentUidField = value;
                this.RaisePropertyChanged("AssignmentUid");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int LastProjectRevision {
            get {
                return this.lastProjectRevisionField;
            }
            set {
                this.lastProjectRevisionField = value;
                this.RaisePropertyChanged("LastProjectRevision");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int LastStatusingRevision {
            get {
                return this.lastStatusingRevisionField;
            }
            set {
                this.lastStatusingRevisionField = value;
                this.RaisePropertyChanged("LastStatusingRevision");
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