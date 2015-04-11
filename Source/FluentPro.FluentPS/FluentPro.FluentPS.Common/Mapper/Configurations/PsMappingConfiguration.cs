using FluentPro.FluentPS.Common.Mapper.Converters.PropertyNameConverters;

namespace FluentPro.FluentPS.Common.Mapper.Configurations
{
    public class PsMappingConfiguration : BaseMappingConfiguration
    {
        public PsMappingConfiguration()
        {
            PropertyNameConverter = new UpperUnderscoreToCamelCasePropertyNameConverter();
        }
    }
}
