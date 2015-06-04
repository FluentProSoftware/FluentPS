using System;
using System.Collections.Generic;
using FluentPro.FluentPS.Psi.Model.Enums;

namespace FluentPro.FluentPS.Psi.Tests.Integration.TaskMapping.Model
{
    public class TaskMappingProject
    {
        public Guid ProjUid { get; set; }

        public string ProjName { get; set; }

        public ProjectType ProjType { get; set; }
    }
}
