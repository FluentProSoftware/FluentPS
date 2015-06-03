using System;
using FluentPro.FluentPS.Psi.Model.Enums;

namespace FluentPro.FluentPS.Psi.Tests.Integration.BasicProjectMapping.Model
{
    public class BasicProject
    {
        public Guid ProjUid { get; set; }

        public string ProjName { get; set; }

        public ProjectType ProjType { get; set; }

        public string WprojDescription { get; set; }

        public string TestProjectText { get; set; }

        public decimal TestProjectNumber { get; set; }

        public decimal TestProjectCost { get; set; }

        public int TestProjectDuration { get; set; }

        public DateTime TestProjectDate { get; set; }

        public bool TestProjectYesNoTrue { get; set; }

        public bool TestProjectYesNoFalse { get; set; }
    }
}
