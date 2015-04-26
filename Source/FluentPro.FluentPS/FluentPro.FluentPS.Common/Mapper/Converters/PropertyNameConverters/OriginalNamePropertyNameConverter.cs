using FluentPro.FluentPS.Common.Mapper.Interfaces;

namespace FluentPro.FluentPS.Common.Mapper.Converters.PropertyNameConverters
{
    public class OriginalNamePropertyNameConverter : IPropertyNameConverter
    {
        public string GetDestName(string sourceName)
        {
            return sourceName;
        }

        public string GetSourceName(string destName)
        {
            return destName;
        }
    }
}
