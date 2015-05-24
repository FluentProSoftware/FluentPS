namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class AnalysisPriorityData : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Guid customFieldUidField;
        
        private double weightField;
        
        private decimal minimumValueField;
        
        private decimal maximumValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid CustomFieldUid {
            get {
                return this.customFieldUidField;
            }
            set {
                this.customFieldUidField = value;
                this.RaisePropertyChanged("CustomFieldUid");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public double Weight {
            get {
                return this.weightField;
            }
            set {
                this.weightField = value;
                this.RaisePropertyChanged("Weight");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public decimal MinimumValue {
            get {
                return this.minimumValueField;
            }
            set {
                this.minimumValueField = value;
                this.RaisePropertyChanged("MinimumValue");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public decimal MaximumValue {
            get {
                return this.maximumValueField;
            }
            set {
                this.maximumValueField = value;
                this.RaisePropertyChanged("MaximumValue");
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