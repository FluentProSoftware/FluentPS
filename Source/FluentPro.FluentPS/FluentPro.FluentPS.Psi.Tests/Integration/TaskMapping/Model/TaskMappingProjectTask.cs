using System;

namespace FluentPro.FluentPS.Psi.Tests.Integration.TaskMapping.Model
{
    public class TaskMappingProjectTask
    {
        public Guid ProjUid { get; set; }

        public Guid TaskUid { get; set; }

        public string TaskName { get; set; }

        public double TaskWork { get; set; }

        public DateTime TaskStartDate { get; set; }

        public DateTime TaskFinishDate { get; set; }

        public string TestTaskText { get; set; }

        public decimal TestTaskNumber { get; set; }

        public decimal TestTaskCost { get; set; }

        public int TestTaskDuration { get; set; }

        public DateTime TestTaskDate { get; set; }

        public bool TestTaskYesNoTrue { get; set; }

        public bool TestTaskYesNoFalse { get; set; }
    }
}
