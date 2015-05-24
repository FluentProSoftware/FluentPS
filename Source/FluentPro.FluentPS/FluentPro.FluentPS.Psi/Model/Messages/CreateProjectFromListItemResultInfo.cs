namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class CreateProjectFromListItemResultInfo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Guid projUidField;
        
        private string projectNameField;
        
        private string[] errorsField;
        
        private string[] warningsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid projUid {
            get {
                return this.projUidField;
            }
            set {
                this.projUidField = value;
                this.RaisePropertyChanged("projUid");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string projectName {
            get {
                return this.projectNameField;
            }
            set {
                this.projectNameField = value;
                this.RaisePropertyChanged("projectName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
        public string[] Errors {
            get {
                return this.errorsField;
            }
            set {
                this.errorsField = value;
                this.RaisePropertyChanged("Errors");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=3)]
        public string[] Warnings {
            get {
                return this.warningsField;
            }
            set {
                this.warningsField = value;
                this.RaisePropertyChanged("Warnings");
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