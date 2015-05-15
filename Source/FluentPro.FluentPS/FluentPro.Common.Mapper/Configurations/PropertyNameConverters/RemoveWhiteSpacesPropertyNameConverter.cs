using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Types;

namespace FluentPro.Common.Mapper.Configurations.PropertyNameConverters
{
    public class RemoveWhiteSpacesPropertyNameConverter : IPropertyNameConverter
    {
        public string GetName(string sourceName)
        {
            return sourceName.Replace(" ", "");
        }

        public static bool CanMap(MappingPair mappingPair)
        {
            if (!mappingPair.Dest.CanContainWhitespacesInProperties)
            {
                return true;
            }

            return false;
        }
    }
}
