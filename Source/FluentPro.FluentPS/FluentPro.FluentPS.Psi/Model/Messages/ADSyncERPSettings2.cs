using FluentPro.FluentPS.Psi.Model.Enums;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/Admin/")]
    public partial class ADSyncERPSettings2
    {
        
        private System.Guid[] aDGroupGuidsField;
        
        private bool scheduledUpdatesField;
        
        private ADSyncStatus statusField;
        
        private System.DateTime lastUpdateTimeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        public System.Guid[] ADGroupGuids
        {
            get
            {
                return this.aDGroupGuidsField;
            }
            set
            {
                this.aDGroupGuidsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool ScheduledUpdates
        {
            get
            {
                return this.scheduledUpdatesField;
            }
            set
            {
                this.scheduledUpdatesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public ADSyncStatus Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public System.DateTime LastUpdateTime
        {
            get
            {
                return this.lastUpdateTimeField;
            }
            set
            {
                this.lastUpdateTimeField = value;
            }
        }
    }
}