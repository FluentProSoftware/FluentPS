using System;
using System.Collections.Generic;
using FluentPro.FluentPS.Psi.Model.Enums;

namespace FluentPro.FluentPS.Psi.Tests.Integration.TaskDetails.Model
{
    public class TaskDetailsProject
    {
        public Guid ProjUid { get; set; }

        public string ProjName { get; set; }

        public ProjectType ProjType { get; set; }

        public string WprojDescription { get; set; }

        public List<TaskDetailsTask> Tasks { get; set; }
    }
}
