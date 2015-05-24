using FluentPro.FluentPS.Psi.Model.DataSets;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class PDPFeatureInfo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private PDPFeatureInformationDataSet pDPFeatureDSField;
        
        private ProjectDataSet projectDSField;
        
        private WorkflowDataSet workflowDSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public PDPFeatureInformationDataSet PDPFeatureDS {
            get {
                return this.pDPFeatureDSField;
            }
            set {
                this.pDPFeatureDSField = value;
                this.RaisePropertyChanged("PDPFeatureDS");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ProjectDataSet ProjectDS {
            get {
                return this.projectDSField;
            }
            set {
                this.projectDSField = value;
                this.RaisePropertyChanged("ProjectDS");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public WorkflowDataSet WorkflowDS {
            get {
                return this.workflowDSField;
            }
            set {
                this.workflowDSField = value;
                this.RaisePropertyChanged("WorkflowDS");
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