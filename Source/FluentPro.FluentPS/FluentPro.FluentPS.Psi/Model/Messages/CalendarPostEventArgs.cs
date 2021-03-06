namespace FluentPro.FluentPS.Psi.Model.Messages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CalendarPreEventArgs))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public partial class CalendarPostEventArgs : PostEventArgs {
        
        private System.Data.DataSet calendarInformationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Data.DataSet CalendarInformation {
            get {
                return this.calendarInformationField;
            }
            set {
                this.calendarInformationField = value;
                this.RaisePropertyChanged("CalendarInformation");
            }
        }
    }
}