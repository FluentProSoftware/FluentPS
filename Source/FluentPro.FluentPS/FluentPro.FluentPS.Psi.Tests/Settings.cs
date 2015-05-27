using System;

namespace FluentPro.FluentPS.Psi.Tests
{
    public static class Settings
    {
        public static Uri PwaUri = new Uri("http://udav/pwa/");

        public static Uri WrongPwaUri = new Uri("http://udav/wrong");

        public static string DefaultProjectName = "FluentPS Integration Tests Project";

        public static Guid DefaultProjectGuid = new Guid("E337221E-C381-4D99-A06E-35579C1D793F");

        public static Guid DefaultSessionGuid = new Guid("4D7A6E61-448D-42B9-A1DD-D0099155B6CC");
    }
}
