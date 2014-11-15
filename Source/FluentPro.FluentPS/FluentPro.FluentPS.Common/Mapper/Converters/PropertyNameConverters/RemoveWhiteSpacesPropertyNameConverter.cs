using FluentPro.FluentPS.Common.Mapper.Interfaces;

namespace FluentPro.FluentPS.Common.Mapper.Converters.PropertyNameConverters
{
    public class RemoveWhiteSpacesPropertyNameConverter : IPropertyNameConverter
    {
        public string GetName(string sourceName)
        {
            return sourceName.Replace(" ", "");
            //yield return Regex.Replace(sourceName, @"((?<=\p{Ll})\p{Lu})|((?!\A)\p{Lu}(?>\p{Ll}))", " $0");
            //yield return Regex.Replace(sourceName, @"((?<=.)[A-Z][a-zA-Z]*)|((?<=[a-zA-Z])\d+)", "_$1$2").ToUpper();
        }
    }
}
