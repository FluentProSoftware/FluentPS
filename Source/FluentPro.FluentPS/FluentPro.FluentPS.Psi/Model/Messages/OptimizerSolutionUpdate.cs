namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class OptimizerSolutionUpdate : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Guid projectUidField;
        
        private string fieldKeyField;
        
        private string updatedValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid ProjectUid {
            get {
                return this.projectUidField;
            }
            set {
                this.projectUidField = value;
                this.RaisePropertyChanged("ProjectUid");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string FieldKey {
            get {
                return this.fieldKeyField;
            }
            set {
                this.fieldKeyField = value;
                this.RaisePropertyChanged("FieldKey");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string UpdatedValue {
            get {
                return this.updatedValueField;
            }
            set {
                this.updatedValueField = value;
                this.RaisePropertyChanged("UpdatedValue");
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