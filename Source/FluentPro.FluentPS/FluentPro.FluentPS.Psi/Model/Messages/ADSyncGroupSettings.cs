using FluentPro.FluentPS.Psi.Model.Enums;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ADSyncERPSettings))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/Admin/")]
    public partial class ADSyncGroupSettings
    {
        
        private bool scheduledUpdatesField;
        
        private ADSyncStatus statusField;
        
        private System.DateTime lastUpdateTimeField;
        
        private int updateFrequencyField;
        
        private ADSyncFrequencyUnit updateFrequencyUnitField;
        
        private System.DateTime startUpdateTimeField;
        
        private bool autoReactivateInactiveUsersField;
        
        private string onlineUserAccountPopertyNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int UpdateFrequency
        {
            get
            {
                return this.updateFrequencyField;
            }
            set
            {
                this.updateFrequencyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public ADSyncFrequencyUnit UpdateFrequencyUnit
        {
            get
            {
                return this.updateFrequencyUnitField;
            }
            set
            {
                this.updateFrequencyUnitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public System.DateTime StartUpdateTime
        {
            get
            {
                return this.startUpdateTimeField;
            }
            set
            {
                this.startUpdateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public bool AutoReactivateInactiveUsers
        {
            get
            {
                return this.autoReactivateInactiveUsersField;
            }
            set
            {
                this.autoReactivateInactiveUsersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string OnlineUserAccountPopertyName
        {
            get
            {
                return this.onlineUserAccountPopertyNameField;
            }
            set
            {
                this.onlineUserAccountPopertyNameField = value;
            }
        }
    }
}