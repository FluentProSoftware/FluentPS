using FluentPro.FluentPS.Psi.Model.DataSets;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class ProjectFieldInfo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int taskCountField;
        
        private ViewFieldsDataSet viewDSField;
        
        private CustomFieldDataSet customFieldDSField;
        
        private ProjectCenterDataSet summaryDSField;
        
        private WorkflowDataSet workflowDSField;
        
        private LookupTableDataSet lookupTableDSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int TaskCount {
            get {
                return this.taskCountField;
            }
            set {
                this.taskCountField = value;
                this.RaisePropertyChanged("TaskCount");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ViewFieldsDataSet ViewDS {
            get {
                return this.viewDSField;
            }
            set {
                this.viewDSField = value;
                this.RaisePropertyChanged("ViewDS");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public CustomFieldDataSet CustomFieldDS {
            get {
                return this.customFieldDSField;
            }
            set {
                this.customFieldDSField = value;
                this.RaisePropertyChanged("CustomFieldDS");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public ProjectCenterDataSet SummaryDS {
            get {
                return this.summaryDSField;
            }
            set {
                this.summaryDSField = value;
                this.RaisePropertyChanged("SummaryDS");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public WorkflowDataSet WorkflowDS {
            get {
                return this.workflowDSField;
            }
            set {
                this.workflowDSField = value;
                this.RaisePropertyChanged("WorkflowDS");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public LookupTableDataSet LookupTableDS {
            get {
                return this.lookupTableDSField;
            }
            set {
                this.lookupTableDSField = value;
                this.RaisePropertyChanged("LookupTableDS");
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