using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Xml.Serialization;

namespace FluentPro.FluentPS.Contracts.Model.Messages
{
    [DebuggerStepThrough]
    [MessageContract(WrapperName = "QueueImportTaskListsResponse", WrapperNamespace = "http://schemas.microsoft.com/office/project/server/webservices/Project/", IsWrapped = true)]
    public partial class QueueImportTaskListsResponse
    {
        [MessageBodyMember(Namespace = "http://schemas.microsoft.com/office/project/server/webservices/Project/", Order = 0)]
        [XmlArrayItem(IsNullable = false)]
        public ImportResult[] QueueImportTaskListsResult;

        public QueueImportTaskListsResponse()
        {
        }

        public QueueImportTaskListsResponse(ImportResult[] QueueImportTaskListsResult)
        {
            this.QueueImportTaskListsResult = QueueImportTaskListsResult;
        }
    }
    
}
