namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class OpenProjectState : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool reConnectedField;
        
        private bool isDocumentDirtyField;
        
        private int editingTimeoutField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool ReConnected {
            get {
                return this.reConnectedField;
            }
            set {
                this.reConnectedField = value;
                this.RaisePropertyChanged("ReConnected");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool IsDocumentDirty {
            get {
                return this.isDocumentDirtyField;
            }
            set {
                this.isDocumentDirtyField = value;
                this.RaisePropertyChanged("IsDocumentDirty");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int EditingTimeout {
            get {
                return this.editingTimeoutField;
            }
            set {
                this.editingTimeoutField = value;
                this.RaisePropertyChanged("EditingTimeout");
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