using System;
using System.Xml.Serialization;

namespace FluentPro.FluentPS.Psi.Model.Enums
{
    [Serializable]
    [XmlType(Namespace = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/")]
    public enum SortColumn
    {
        Undefined,
        CorrelationGUID,
        CorrelationPriority,
        GroupPriority,
        JobCompletionState,
        JobGUID,
        JobGroupGUID,
        JobInfoGUID,
        LastAdminAction,
        MachineName,
        MessageType,
        PercentComplete,
        QueueCompletedTime,
        QueueEntryTime,
        QueueId,
        QueuePosition,
        QueueProcessingTime,
        QueueWakeupTime,
        ResourceGUID,
        ServiceName,
        LastColumn
    }
}
