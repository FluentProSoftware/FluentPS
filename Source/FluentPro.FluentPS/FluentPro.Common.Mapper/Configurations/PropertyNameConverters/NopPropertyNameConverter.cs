using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Types;

namespace FluentPro.Common.Mapper.Configurations.PropertyNameConverters
{
    public class NopPropertyNameConverter : IPropertyNameConverter
    {
        public string GetName(string sourceName)
        {
            return sourceName;
        }

        public static bool CanMap(MappingPair mappingPair)
        {
            if (mappingPair.Src.CanContainWhitespacesInProperties && mappingPair.Dest.CanContainWhitespacesInProperties)
            {
                return true;
            }

            if (!mappingPair.Src.CanContainWhitespacesInProperties && !mappingPair.Dest.CanContainWhitespacesInProperties)
            {
                return true;
            }

            return false;
        }
    }
}
