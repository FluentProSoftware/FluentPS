using System;
using System.Xml.Serialization;

namespace FluentPro.FluentPS.Psi.Model.Enums
{
    [Serializable]
    [XmlType(Namespace = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/")]
    public enum JobState
    {
        Unknown,
        ReadyForProcessing,
        SendIncomplete,
        Processing,
        Success,
        Failed,
        FailedNotBlocking,
        ProcessingDeferred,
        CorrelationBlocked,
        Canceled,
        OnHold,
        Sleeping,
        ReadyForLaunch,
        LastState
    }
}
