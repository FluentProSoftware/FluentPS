using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using FluentPro.FluentPS.Psi.Model.Enums;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "QueuePurgeArchivedJobs", WrapperNamespace = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/", IsWrapped = true)]
    public partial class QueuePurgeArchivedJobsRequest
    {
        [MessageBodyMember(Namespace = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/", Order = 0)]
        public Guid jobUid;

        [MessageBodyMember(Namespace = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/", Order = 1)]
        public QueueID queueId;

        [MessageBodyMember(Namespace = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/", Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<Guid> correlationUID;

        [MessageBodyMember(Namespace = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/", Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<QueueMsgType> messageType;

        [MessageBodyMember(Namespace = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/", Order = 4)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<int> hoursHistory;

        public QueuePurgeArchivedJobsRequest()
        {
        }

        public QueuePurgeArchivedJobsRequest(Guid jobUid, QueueID queueId, System.Nullable<Guid> correlationUID, System.Nullable<QueueMsgType> messageType, System.Nullable<int> hoursHistory)
        {
            this.jobUid = jobUid;
            this.queueId = queueId;
            this.correlationUID = correlationUID;
            this.messageType = messageType;
            this.hoursHistory = hoursHistory;
        }
    }
}
