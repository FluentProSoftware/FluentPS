using FluentPro.FluentPS.Common.Mapper.Interfaces;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FluentPro.FluentPS.Common.Mapper.Conventions.Naming
{
    public class DefaultNamingConvention : INamingConvention
    {
        public IEnumerable<string> GetNames(string sourceName)
        {
            yield return sourceName;
            yield return Regex.Replace(sourceName, @"((?<=\p{Ll})\p{Lu})|((?!\A)\p{Lu}(?>\p{Ll}))", " $0");
            yield return Regex.Replace(sourceName, @"((?<=.)[A-Z][a-zA-Z]*)|((?<=[a-zA-Z])\d+)", "_$1$2").ToUpper();
        }
    }
}
