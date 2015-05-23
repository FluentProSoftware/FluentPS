namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/CubeAdmin/")]
    public partial class CBSRequestMessage
    {
        
        private System.Guid cbsSettingUidField;
        
        private string aSServerNameField;
        
        private string aSDBNameField;
        
        private string aSDatabaseDescriptionField;
        
        private string aSExtraNetAddressField;
        
        private int iRangeChoiceField;
        
        private int iPastNumField;
        
        private int iPastUnitField;
        
        private int iNextNumField;
        
        private int iNextUnitField;
        
        private System.DateTime dtFromDateField;
        
        private System.DateTime dtToDateField;
        
        private bool bHighPriorityField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid cbsSettingUid
        {
            get
            {
                return this.cbsSettingUidField;
            }
            set
            {
                this.cbsSettingUidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ASServerName
        {
            get
            {
                return this.aSServerNameField;
            }
            set
            {
                this.aSServerNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string ASDBName
        {
            get
            {
                return this.aSDBNameField;
            }
            set
            {
                this.aSDBNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string ASDatabaseDescription
        {
            get
            {
                return this.aSDatabaseDescriptionField;
            }
            set
            {
                this.aSDatabaseDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string ASExtraNetAddress
        {
            get
            {
                return this.aSExtraNetAddressField;
            }
            set
            {
                this.aSExtraNetAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public int iRangeChoice
        {
            get
            {
                return this.iRangeChoiceField;
            }
            set
            {
                this.iRangeChoiceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public int iPastNum
        {
            get
            {
                return this.iPastNumField;
            }
            set
            {
                this.iPastNumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public int iPastUnit
        {
            get
            {
                return this.iPastUnitField;
            }
            set
            {
                this.iPastUnitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public int iNextNum
        {
            get
            {
                return this.iNextNumField;
            }
            set
            {
                this.iNextNumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public int iNextUnit
        {
            get
            {
                return this.iNextUnitField;
            }
            set
            {
                this.iNextUnitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public System.DateTime dtFromDate
        {
            get
            {
                return this.dtFromDateField;
            }
            set
            {
                this.dtFromDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public System.DateTime dtToDate
        {
            get
            {
                return this.dtToDateField;
            }
            set
            {
                this.dtToDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public bool bHighPriority
        {
            get
            {
                return this.bHighPriorityField;
            }
            set
            {
                this.bHighPriorityField = value;
            }
        }
    }
}