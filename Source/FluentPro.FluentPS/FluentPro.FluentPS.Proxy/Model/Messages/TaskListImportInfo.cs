using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://schemas.microsoft.com/office/project/server/webservices/Project/")]
    public partial class TaskListImportInfo
    {
        [XmlElement(Order = 0)]
        public Guid WebUniqueId { get; set; }

        [XmlElement(Order = 1)]
        public Guid ListUniqueId { get; set; }

        [XmlElement(Order = 2)]
        public Guid ProjectUniqueId { get; set; }

        [XmlElement(Order = 3)]
        public string ProjectName { get; set; }
    }
}
