using FluentPro.FluentPS.Psi.Model.DataSets;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LookupTablePreEventArgs))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class LookupTablePostEventArgs : PostEventArgs {
        
        private LookupTableMultiLangDataSet lookupTableInformationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public LookupTableMultiLangDataSet LookupTableInformation {
            get {
                return this.lookupTableInformationField;
            }
            set {
                this.lookupTableInformationField = value;
                this.RaisePropertyChanged("LookupTableInformation");
            }
        }
    }
}