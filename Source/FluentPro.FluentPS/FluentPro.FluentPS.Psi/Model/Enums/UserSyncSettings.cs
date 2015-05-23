using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentPro.FluentPS.Psi.Model.Enums
{
    /// <remarks/>
    [System.FlagsAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/office/project/server/webservices/Admin/")]
    public enum UserSyncSettings
    {

        /// <remarks/>
        Enabled = 1,

        /// <remarks/>
        DisablePWA = 2,

        /// <remarks/>
        DisablePWS = 4,

        /// <remarks/>
        DisableEmailSync = 8,

        /// <remarks/>
        DisableAll = 16,

        /// <remarks/>
        DisableVisbilityProjects = 32,

        /// <remarks/>
        DisableEverything = 64,
    }
}
