using FluentPro.FluentPS.Common.Mapper.Interfaces;

namespace FluentPro.FluentPS.Common.Mapper.Conventions.Naming
{
    public class DefaultNamingConvention : INamingConvention
    {
        public string GetName(string sourceName)
        {
            return sourceName;
        }
    }
}
