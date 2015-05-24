using FluentPro.FluentPS.Psi.Model.DataSets;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class OrganizationalPermissionsPreUpdateEventArgs : PreEventArgs {
        
        private SecurityOrganizationalPermissionsDataSet dsDeltaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public SecurityOrganizationalPermissionsDataSet DsDelta {
            get {
                return this.dsDeltaField;
            }
            set {
                this.dsDeltaField = value;
                this.RaisePropertyChanged("DsDelta");
            }
        }
    }
}