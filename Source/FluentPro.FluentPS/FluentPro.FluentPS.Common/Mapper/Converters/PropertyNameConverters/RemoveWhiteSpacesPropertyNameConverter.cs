using FluentPro.FluentPS.Common.Mapper.Interfaces;

namespace FluentPro.FluentPS.Common.Mapper.Converters.PropertyNameConverters
{
    public class RemoveWhiteSpacesPropertyNameConverter : IPropertyNameConverter
    {
        public string GetName(string sourceName)
        {
            return sourceName.Replace(" ", "");
        }
    }
}
