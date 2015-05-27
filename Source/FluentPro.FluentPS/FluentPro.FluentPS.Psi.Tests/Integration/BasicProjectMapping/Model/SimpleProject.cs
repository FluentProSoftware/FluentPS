using System;
using FluentPro.FluentPS.Psi.Model.Enums;

namespace FluentPro.FluentPS.Psi.Tests.Integration.BasicProjectMapping.Model
{
    public class SimpleProject
    {
        public Guid ProjUid { get; set; }

        public string ProjName { get; set; }

        public ProjectType ProjType { get; set; }

        public string WprojDescription { get; set; }
    }
}
