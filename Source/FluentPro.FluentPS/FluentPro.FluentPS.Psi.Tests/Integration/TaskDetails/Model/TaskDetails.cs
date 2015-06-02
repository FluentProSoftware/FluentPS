using System;

namespace FluentPro.FluentPS.Psi.Tests.Integration.TaskDetails.Model
{
    public class TaskDetails
    {
        public Guid AssnUid { get; set; }

        public Guid ProjUid { get; set; }

        public Guid TaskUid { get; set; }

        public string TaskName { get; set; }

        public decimal TaskWork { get; set; }

        public decimal TaskRemWork { get; set; }

        public decimal TaskActWork { get; set; }

        public DateTime TaskStartDate { get; set; }

        public DateTime TaskFinishDate { get; set; }

        public string TaskNotes { get; set; }
    }
}
