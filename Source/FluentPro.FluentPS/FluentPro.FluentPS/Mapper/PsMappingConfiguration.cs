using FluentPro.Common.Mapper.Configurations;
using FluentPro.Common.Mapper.Types;
using FluentPro.FluentPS.Mapper.MappingObjects;
using FluentPro.FluentPS.Mapper.PropsMatchers;

namespace FluentPro.FluentPS.Mapper
{
    public class PsMappingConfiguration : DefaultMappingConfiguration
    {
        public PsMappingConfiguration()
        {
            MappingObjects.Insert(0, new FuncToTypeListItem<object>(NativeFieldsDataTableMappingObject.IsValid, typeof(NativeFieldsDataTableMappingObject)));
            MappingObjects.Insert(0, new FuncToTypeListItem<object>(CustomFieldsDataTableMappingObject.IsValid, typeof(CustomFieldsDataTableMappingObject)));

            PropertyNameConverters.Insert(0, new FuncToTypeListItem<MappingPair>(PsToCamelCasePropsMatcher.CanMap, typeof(PsToCamelCasePropsMatcher)));
            PropertyNameConverters.Insert(0, new FuncToTypeListItem<MappingPair>(CamelCaseToPsPropsMatcher.CanMap, typeof(CamelCaseToPsPropsMatcher)));
        }
    }
}
