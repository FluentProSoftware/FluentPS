namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class UserDelegationDeletePreEventArgs : PreEventArgs {
        
        private UserDelegationInfo[] deletedDelegationsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        public UserDelegationInfo[] DeletedDelegations {
            get {
                return this.deletedDelegationsField;
            }
            set {
                this.deletedDelegationsField = value;
                this.RaisePropertyChanged("DeletedDelegations");
            }
        }
    }
}