using FluentPro.FluentPS.Psi.Model.DataSets;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class ProjectPostUpdatedEventArgs : ProjectPostEventArgs {
        
        private ProjectDataSet projectDataSetField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ProjectDataSet ProjectDataSet {
            get {
                return this.projectDataSetField;
            }
            set {
                this.projectDataSetField = value;
                this.RaisePropertyChanged("ProjectDataSet");
            }
        }
    }
}