using FluentPro.FluentPS.Psi.Exceptions.Faults;
using FluentPro.FluentPS.Psi.Model.DataSets;
using FluentPro.FluentPS.Psi.Model.Enums;
using FluentPro.FluentPS.Psi.Model.Messages;
using System;
using System.ServiceModel;

namespace FluentPro.FluentPS.Psi.Interfaces.Psi
{
    [ServiceContractAttribute(Namespace = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/", ConfigurationName = "SvcQueueSystem.QueueSystem")]
    public interface IQueueSystem
    {
        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/CancelJob", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/CancelJobResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/CancelJobDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/CancelJobServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void CancelJob(Guid jobUID, bool cancelCorrelationJobs, bool cancelSendIncompleteJobs);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/CancelJobSimple", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/CancelJobSimpleResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/CancelJobSimpleServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/CancelJobSimpleDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void CancelJobSimple(Guid jobUID);
        
        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/CancelCorrelation", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/CancelCorrelationResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/CancelCorrelationServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/CancelCorrelationDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void CancelCorrelation(Guid correlationUID, bool cancelSendIncompleteJobs);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/GetJobCompletionState", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/GetJobCompletionStateResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/GetJobCompletionStateServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/GetJobCompletionStateDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        GetJobCompletionStateResponse GetJobCompletionState(GetJobCompletionStateRequest request);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/UnblockCorrelation", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/UnblockCorrelationResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/UnblockCorrelationDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/UnblockCorrelationServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void UnblockCorrelation(Guid correlationGUID);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/RetryJob", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/RetryJobResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/RetryJobServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/RetryJobDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void RetryJob(Guid JobGUID);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/RetryCorrelation", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/RetryCorrelationResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/RetryCorrelationServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/RetryCorrelationDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void RetryCorrelation(Guid correlationGUID);

        // CODEGEN: Parameter 'correlationUID' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueuePurgeArchivedJobs", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueuePurgeArchivedJobsResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/QueuePurgeArchivedJobsDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/QueuePurgeArchivedJobsServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        QueuePurgeArchivedJobsResponse QueuePurgeArchivedJobs(QueuePurgeArchivedJobsRequest request);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/GetProposedJobWaitTime", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/GetProposedJobWaitTimeResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/GetProposedJobWaitTimeDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/GetProposedJobWaitTimeServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        int GetProposedJobWaitTime(Guid correlationUID, QueueMsgType messageType);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/GetJobGroupWaitTime", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/GetJobGroupWaitTimeResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/GetJobGroupWaitTimeServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/GetJobGroupWaitTimeDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        int GetJobGroupWaitTime(Guid trackingID, QueueMsgType messageType);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/GetJobGroupWaitTimeSimple", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/GetJobGroupWaitTimeSimpleResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/GetJobGroupWaitTimeSimpleServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/GetJobGroupWaitTimeSimpleDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        int GetJobGroupWaitTimeSimple(Guid trackingID);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/GetJobWaitTime", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/GetJobWaitTimeResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/GetJobWaitTimeDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/GetJobWaitTimeServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        int GetJobWaitTime(Guid jobID);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/ReadAllJobStatusSimple", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/ReadAllJobStatusSimpleResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/ReadAllJobStatusSimpleDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/ReadAllJobStatusSimpleServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        QueueStatusDataSet ReadAllJobStatusSimple(DateTime fromDate, DateTime toDate, int maxRows, bool includeWaitTime, SortColumn sortColumn, SortOrder sortOrder);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/ReadAllJobStatus", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/ReadAllJobStatusResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/ReadAllJobStatusServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/ReadAllJobStatusDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        QueueStatusDataSet ReadAllJobStatus(JobState[] jobStates, QueueMsgType[] messageTypes, DateTime fromDate, DateTime toDate, int maxRows, bool includeWaitTime, SortColumn sortColumn, SortOrder sortOrder);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/ReadProjectJobStatus", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/ReadProjectJobStatusResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/ReadProjectJobStatusServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/ReadProjectJobStatusDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        QueueStatusDataSet ReadProjectJobStatus(Guid[] projectGUIDs, QueueMsgType[] messageTypes, JobState[] JobCompletionStates, DateTime fromDate, DateTime toDate, int maxRows, bool includeWaitTime, SortColumn sortColumn, SortOrder sortOrder);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/ReadMyJobStatus", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/ReadMyJobStatusResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/ReadMyJobStatusServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/ReadMyJobStatusDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        QueueStatusDataSet ReadMyJobStatus(QueueMsgType[] messageTypes, JobState[] JobCompletionState, DateTime fromDate, DateTime toDate, int maxRows, bool includeWaitTime, SortColumn sortColumn, SortOrder sortOrder);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/GetMyJobCount", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/GetMyJobCountResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/GetMyJobCountDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/GetMyJobCountServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        int GetMyJobCount(QueueMsgType[] messageTypes, JobState[] JobCompletionState, DateTime fromDate, DateTime toDate, int maxRows);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/ReadJobStatus", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/ReadJobStatusResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/ReadJobStatusServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/ReadJobStatusDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        QueueStatusDataSet ReadJobStatus(QueueStatusRequestDataSet qsrDS, bool includeWaitTime, SortColumn sortColumn, SortOrder sortOrder);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/ReadJobStatusSimple", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/ReadJobStatusSimpleResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/ReadJobStatusSimpleServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/ReadJobStatusSimpleDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        QueueStatusDataSet ReadJobStatusSimple(Guid[] jobUIDs, bool includeWaitTime);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/GetJobCount", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/GetJobCountResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/GetJobCountServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/GetJobCountDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        int GetJobCount(Guid[] CorrelationGUIDs, JobState[] jobStates, QueueMsgType[] messageTypes);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/ReadQueueConfiguration", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/ReadQueueConfigurationResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/ReadQueueConfigurationServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/ReadQueueConfigurationDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        string ReadQueueConfiguration(QueueID queueId);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/SetQueueConfiguration", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/SetQueueConfigurationResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/SetQueueConfigurationServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/SetQueueConfigurationDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void SetQueueConfiguration(QueueID queueId, string name, string value);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/PurgeQueueStatistics", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/PurgeQueueStatisticsResponse")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/PurgeQueueStatisticsDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/PurgeQueueStatisticsServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void PurgeQueueStatistics(QueueMsgType[] messageTypes);

        [OperationContract(Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/CancelJobAndCorrelation", ReplyAction = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/CancelJobAndCorrelationResponse")]
        [FaultContract(typeof(ServerExecutionFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/CancelJobAndCorrelationServerExecutionFaultFault", Name = "ServerExecutionFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [FaultContract(typeof(DefaultServerFault), Action = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/QueueSystem/CancelJobAndCorrelationDefaultServerFaultFault", Name = "DefaultServerFault", Namespace = "http://Microsoft.Office.Project.Interfaces/")]
        [XmlSerializerFormat]
        void CancelJobAndCorrelation(Guid jobUID, bool cancelSendIncompleteJobs);
    }
}
