using FluentPro.FluentPS.Psi.Model.Enums;
using System;

namespace FluentPro.FluentPS.Psi.Tests.Model
{
    public class SimpleProject
    {
        public Guid ProjUid { get; set; }

        public string ProjName { get; set; }

        public ProjectType ProjType { get; set; }
    }
}
