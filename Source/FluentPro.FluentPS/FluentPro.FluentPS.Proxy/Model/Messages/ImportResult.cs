using System;
using System.Diagnostics;
using System.Xml.Serialization;
using FluentPro.FluentPS.Psi.Model.Enums;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://schemas.microsoft.com/office/project/server/webservices/Project/")]
    public partial class ImportResult
    {
        [XmlElement(Order = 0)]
        public Guid JobUid { get; set; }

        [XmlArray(Order = 1)]
        public PSErrorID[] ErrorList { get; set; }
    }

}
