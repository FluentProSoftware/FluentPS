using FluentPro.FluentPS.Psi.Model.DataSets;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class ResourceAuthorizationPreEventArgs : PreEventArgs {
        
        private ResourceAuthorizationDataSet resourceAuthorizationInformationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ResourceAuthorizationDataSet ResourceAuthorizationInformation {
            get {
                return this.resourceAuthorizationInformationField;
            }
            set {
                this.resourceAuthorizationInformationField = value;
                this.RaisePropertyChanged("ResourceAuthorizationInformation");
            }
        }
    }
}