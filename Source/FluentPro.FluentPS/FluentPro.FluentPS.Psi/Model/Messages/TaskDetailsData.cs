using FluentPro.FluentPS.Psi.Model.DataSets;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class TaskDetailsData : object, System.ComponentModel.INotifyPropertyChanged {
        
        private StatusingTaskContactDataSet taskContactsField;
        
        private StatusingAssignmentDependenciesDataSet assignmentDepenciesField;
        
        private AssnHistoryDataSet assignmentTransactionHistoryField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public StatusingTaskContactDataSet TaskContacts {
            get {
                return this.taskContactsField;
            }
            set {
                this.taskContactsField = value;
                this.RaisePropertyChanged("TaskContacts");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public StatusingAssignmentDependenciesDataSet AssignmentDepencies {
            get {
                return this.assignmentDepenciesField;
            }
            set {
                this.assignmentDepenciesField = value;
                this.RaisePropertyChanged("AssignmentDepencies");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public AssnHistoryDataSet AssignmentTransactionHistory {
            get {
                return this.assignmentTransactionHistoryField;
            }
            set {
                this.assignmentTransactionHistoryField = value;
                this.RaisePropertyChanged("AssignmentTransactionHistory");
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