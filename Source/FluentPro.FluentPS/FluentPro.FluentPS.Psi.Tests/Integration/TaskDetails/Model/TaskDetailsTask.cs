using System;

namespace FluentPro.FluentPS.Psi.Tests.Integration.TaskDetails.Model
{
    public class TaskDetailsTask
    {
        public Guid ProjUid { get; set; }

        public Guid TaskUid { get; set; }

        public string TaskName { get; set; }

        public double TaskWork { get; set; }

        public DateTime TaskStartDate { get; set; }

        public DateTime TaskFinishDate { get; set; }
    }
}
