namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class ReadStatusIncrementalQuery : object, System.ComponentModel.INotifyPropertyChanged {
        
        private ExistingAssignmentInfo[] existingAssignmentsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        public ExistingAssignmentInfo[] ExistingAssignments {
            get {
                return this.existingAssignmentsField;
            }
            set {
                this.existingAssignmentsField = value;
                this.RaisePropertyChanged("ExistingAssignments");
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