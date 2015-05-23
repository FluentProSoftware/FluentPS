namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/Admin/")]
    public partial class ADSyncERPSettings : ADSyncGroupSettings
    {
        
        private System.Guid aDGroupGuidField;
        
        private string aDGroupFQDNField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid ADGroupGuid
        {
            get
            {
                return this.aDGroupGuidField;
            }
            set
            {
                this.aDGroupGuidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ADGroupFQDN
        {
            get
            {
                return this.aDGroupFQDNField;
            }
            set
            {
                this.aDGroupFQDNField = value;
            }
        }
    }
}