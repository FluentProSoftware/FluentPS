using System;

namespace FluentPro.FluentPS.Psi.Tests.Model
{
    public class TaskDetails
    {
        public Guid AssnUid { get; set; }

        public Guid ProjUid { get; set; }

        public Guid TaskUid { get; set; }

        public string TaskName { get; set; }

        public double TaskWork { get; set; }

        public double TaskRemWork { get; set; }

        public double TaskActWork { get; set; }

        public DateTime TaskStartDate { get; set; }

        public DateTime TaskFinishDate { get; set; }

        public string TaskNotes { get; set; }
    }
}
