using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    [DebuggerStepThrough]
    [MessageContract(WrapperName = "QueueImportTaskLists", WrapperNamespace = "http://schemas.microsoft.com/office/project/server/webservices/Project/", IsWrapped = true)]
    public partial class QueueImportTaskListsRequest
    {
        [MessageBodyMember(Namespace = "http://schemas.microsoft.com/office/project/server/webservices/Project/", Order = 0)]
        [XmlArrayItem(IsNullable = false)]
        public TaskListImportInfo[] taskListImportInfo;

        public QueueImportTaskListsRequest()
        {
        }

        public QueueImportTaskListsRequest(TaskListImportInfo[] taskListImportInfo)
        {
            this.taskListImportInfo = taskListImportInfo;
        }
    }

}
