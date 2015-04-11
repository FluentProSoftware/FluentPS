using FluentPro.FluentPS.Common.Mapper.Converters.PropertyNameConverters;

namespace FluentPro.FluentPS.Common.Mapper.Configurations
{
    public class PlainMappingConfiguration : BaseMappingConfiguration
    {
        public PlainMappingConfiguration()
        {
            PropertyNameConverter = new RemoveWhiteSpacesPropertyNameConverter();
        }
    }
}
