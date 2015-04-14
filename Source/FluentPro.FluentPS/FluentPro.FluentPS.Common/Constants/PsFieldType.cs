using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentPro.FluentPS.Common.Constants
{
    /// <summary>
    /// Partial copy of Microsoft.Office.Project.Server.Library.PSDataType,
    /// only essential enum members copied
    /// </summary>
    public enum PsFieldType
    {
        DATE = 4,
        DURATION = 6,
        COST = 9,
        NUMBER = 15,
        YESNO = 17,
        STRING = 21,
        GUID = 42
    }
}
