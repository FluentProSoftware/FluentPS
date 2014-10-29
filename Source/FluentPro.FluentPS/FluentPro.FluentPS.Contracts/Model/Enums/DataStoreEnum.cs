﻿using System;
using System.Xml.Serialization;

namespace FluentPro.FluentPS.Contracts.Model.Enums
{
    [Serializable]
    [XmlType(Namespace = "http://schemas.microsoft.com/office/project/server/webservices/Project/")]
    public enum DataStoreEnum
    {
        WorkingStore,
        PublishedStore,
        VersionsStore,
        ReportingStore
    }
}