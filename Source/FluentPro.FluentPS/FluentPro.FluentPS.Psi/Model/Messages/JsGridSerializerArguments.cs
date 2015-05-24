namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class JsGridSerializerArguments : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string[] autoFilterColumnKeysField;
        
        private bool disableGanttField;
        
        private bool disableRecordKeyHashField;
        
        private System.Nullable<System.Guid> ganttSchemeUidField;
        
        private string[] groupColumnNamesField;
        
        private bool[] groupColumnOrdersField;
        
        private System.Guid groupSchemeUidField;
        
        private bool hideTopOutlineLevelField;
        
        private string hierarchyStateJsonField;
        
        private string[] pagingInfoField;
        
        private System.Nullable<uint> rememberedRecordKeyHashField;
        
        private int requestTypeField;
        
        private string rowAutoFilterStateJsonField;
        
        private string rowFilterXmlField;
        
        private string[] sortColumnNamesField;
        
        private bool[] sortColumnOrdersField;
        
        private bool serializeLookupTableInfoField;
        
        private bool serializeStylesField;
        
        private bool serializeUnfilteredHierarchyField;
        
        private bool showTimeWithDatesField;
        
        private System.Nullable<int> viewOutlineLevelField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        public string[] AutoFilterColumnKeys {
            get {
                return this.autoFilterColumnKeysField;
            }
            set {
                this.autoFilterColumnKeysField = value;
                this.RaisePropertyChanged("AutoFilterColumnKeys");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool DisableGantt {
            get {
                return this.disableGanttField;
            }
            set {
                this.disableGanttField = value;
                this.RaisePropertyChanged("DisableGantt");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool DisableRecordKeyHash {
            get {
                return this.disableRecordKeyHashField;
            }
            set {
                this.disableRecordKeyHashField = value;
                this.RaisePropertyChanged("DisableRecordKeyHash");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public System.Nullable<System.Guid> GanttSchemeUid {
            get {
                return this.ganttSchemeUidField;
            }
            set {
                this.ganttSchemeUidField = value;
                this.RaisePropertyChanged("GanttSchemeUid");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=4)]
        public string[] GroupColumnNames {
            get {
                return this.groupColumnNamesField;
            }
            set {
                this.groupColumnNamesField = value;
                this.RaisePropertyChanged("GroupColumnNames");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=5)]
        public bool[] GroupColumnOrders {
            get {
                return this.groupColumnOrdersField;
            }
            set {
                this.groupColumnOrdersField = value;
                this.RaisePropertyChanged("GroupColumnOrders");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public System.Guid GroupSchemeUid {
            get {
                return this.groupSchemeUidField;
            }
            set {
                this.groupSchemeUidField = value;
                this.RaisePropertyChanged("GroupSchemeUid");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public bool HideTopOutlineLevel {
            get {
                return this.hideTopOutlineLevelField;
            }
            set {
                this.hideTopOutlineLevelField = value;
                this.RaisePropertyChanged("HideTopOutlineLevel");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string HierarchyStateJson {
            get {
                return this.hierarchyStateJsonField;
            }
            set {
                this.hierarchyStateJsonField = value;
                this.RaisePropertyChanged("HierarchyStateJson");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=9)]
        public string[] PagingInfo {
            get {
                return this.pagingInfoField;
            }
            set {
                this.pagingInfoField = value;
                this.RaisePropertyChanged("PagingInfo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
        public System.Nullable<uint> RememberedRecordKeyHash {
            get {
                return this.rememberedRecordKeyHashField;
            }
            set {
                this.rememberedRecordKeyHashField = value;
                this.RaisePropertyChanged("RememberedRecordKeyHash");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public int RequestType {
            get {
                return this.requestTypeField;
            }
            set {
                this.requestTypeField = value;
                this.RaisePropertyChanged("RequestType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string RowAutoFilterStateJson {
            get {
                return this.rowAutoFilterStateJsonField;
            }
            set {
                this.rowAutoFilterStateJsonField = value;
                this.RaisePropertyChanged("RowAutoFilterStateJson");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string RowFilterXml {
            get {
                return this.rowFilterXmlField;
            }
            set {
                this.rowFilterXmlField = value;
                this.RaisePropertyChanged("RowFilterXml");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=14)]
        public string[] SortColumnNames {
            get {
                return this.sortColumnNamesField;
            }
            set {
                this.sortColumnNamesField = value;
                this.RaisePropertyChanged("SortColumnNames");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=15)]
        public bool[] SortColumnOrders {
            get {
                return this.sortColumnOrdersField;
            }
            set {
                this.sortColumnOrdersField = value;
                this.RaisePropertyChanged("SortColumnOrders");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public bool SerializeLookupTableInfo {
            get {
                return this.serializeLookupTableInfoField;
            }
            set {
                this.serializeLookupTableInfoField = value;
                this.RaisePropertyChanged("SerializeLookupTableInfo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public bool SerializeStyles {
            get {
                return this.serializeStylesField;
            }
            set {
                this.serializeStylesField = value;
                this.RaisePropertyChanged("SerializeStyles");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public bool SerializeUnfilteredHierarchy {
            get {
                return this.serializeUnfilteredHierarchyField;
            }
            set {
                this.serializeUnfilteredHierarchyField = value;
                this.RaisePropertyChanged("SerializeUnfilteredHierarchy");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=19)]
        public bool ShowTimeWithDates {
            get {
                return this.showTimeWithDatesField;
            }
            set {
                this.showTimeWithDatesField = value;
                this.RaisePropertyChanged("ShowTimeWithDates");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=20)]
        public System.Nullable<int> ViewOutlineLevel {
            get {
                return this.viewOutlineLevelField;
            }
            set {
                this.viewOutlineLevelField = value;
                this.RaisePropertyChanged("ViewOutlineLevel");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}