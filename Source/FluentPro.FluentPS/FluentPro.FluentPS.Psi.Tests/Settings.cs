using System;

namespace FluentPro.FluentPS.Psi.Tests
{
    public static class Settings
    {
        public static Uri PwaUri = new Uri("http://udav/pwa/");

        public static Uri WrongPwaUri = new Uri("http://udav/wrong");

        public static string DefaultProjectName = "FluentPS Integration Tests Project";

        public static Guid DefaultProjectGuid = new Guid("E337221E-C381-4D99-A06E-35579C1D793F");
    }
}
