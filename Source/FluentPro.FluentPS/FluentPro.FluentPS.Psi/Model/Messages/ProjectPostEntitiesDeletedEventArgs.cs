namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class ProjectPostEntitiesDeletedEventArgs : ProjectPostEventArgs {
        
        private System.Guid[] entitiesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        public System.Guid[] Entities {
            get {
                return this.entitiesField;
            }
            set {
                this.entitiesField = value;
                this.RaisePropertyChanged("Entities");
            }
        }
    }
}