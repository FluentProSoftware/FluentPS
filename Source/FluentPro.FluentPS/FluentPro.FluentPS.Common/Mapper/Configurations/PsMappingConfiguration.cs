using FluentPro.FluentPS.Common.Mapper.Converters.PropertyNameConverters;
using FluentPro.FluentPS.Common.Mapper.MappingStrategies;

namespace FluentPro.FluentPS.Common.Mapper.Configurations
{
    public class PsMappingConfiguration : BaseMappingConfiguration
    {
        public PsMappingConfiguration()
        {
            PropertyNameConverter = new UpperUnderscoreToCamelCasePropertyNameConverter();

            MappingStrategies.Insert(0, new PsCustomFieldsToEntityMappingStrategy());
        }
    }
}
