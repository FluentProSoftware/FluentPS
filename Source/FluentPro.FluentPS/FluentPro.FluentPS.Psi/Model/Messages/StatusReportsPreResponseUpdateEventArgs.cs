using FluentPro.FluentPS.Psi.Model.DataSets;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class StatusReportsPreResponseUpdateEventArgs : PreEventArgs {
        
        private StatusReportsDataSet statusReportsDataSetField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public StatusReportsDataSet statusReportsDataSet {
            get {
                return this.statusReportsDataSetField;
            }
            set {
                this.statusReportsDataSetField = value;
                this.RaisePropertyChanged("statusReportsDataSet");
            }
        }
    }
}