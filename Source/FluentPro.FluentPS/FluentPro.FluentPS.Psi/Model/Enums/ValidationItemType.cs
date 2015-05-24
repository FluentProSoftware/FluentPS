namespace FluentPro.FluentPS.Psi.Model.Enums
{
    /// <remarks/>
    [System.FlagsAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.57.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/")]
    public enum ValidationItemType {
        
        /// <remarks/>
        ProjectData = 1,
        
        /// <remarks/>
        ProjectWssData = 2,
        
        /// <remarks/>
        Resource = 4,
        
        /// <remarks/>
        User = 8,
        
        /// <remarks/>
        CustomField = 16,
        
        /// <remarks/>
        ReportingTimetable = 32,
        
        /// <remarks/>
        Timesheet = 64,
        
        /// <remarks/>
        TimesheetClass = 128,
        
        /// <remarks/>
        TimesheetStatus = 256,
        
        /// <remarks/>
        TimesheetPeriod = 512,
        
        /// <remarks/>
        TimesheetPeriodStatus = 1024,
        
        /// <remarks/>
        LookupTable = 2048,
        
        /// <remarks/>
        Calendar = 4096,
        
        /// <remarks/>
        WorkflowPhases = 8192,
        
        /// <remarks/>
        WorkflowStages = 16384,
        
        /// <remarks/>
        EnterpriseProjectTypes = 32768,
        
        /// <remarks/>
        ProjectWorkflowStatusData = 65536,
        
        /// <remarks/>
        TimesheetCustomField = 131072,
        
        /// <remarks/>
        CommitData = 262144,
        
        /// <remarks/>
        All = 524288,
    }
}