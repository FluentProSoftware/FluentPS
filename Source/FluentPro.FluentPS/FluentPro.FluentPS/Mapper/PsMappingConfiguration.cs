using FluentPro.Common.Mapper.Configurations;
using FluentPro.Common.Mapper.Types;
using FluentPro.FluentPS.Mapper.MappingObjects;
using FluentPro.FluentPS.Mapper.PropertyNameConverters;

namespace FluentPro.FluentPS.Mapper
{
    public class PsMappingConfiguration : DefaultMappingConfiguration
    {
        public PsMappingConfiguration()
        {
            MappingObjects.Insert(0, new FuncToTypeListItem<object>(ProjectNativeFieldsDataTableMappingObject.IsValid, typeof(ProjectNativeFieldsDataTableMappingObject)));
            MappingObjects.Insert(0, new FuncToTypeListItem<object>(ProjectCustomFieldsDataTableMappingObject.IsValid, typeof(ProjectCustomFieldsDataTableMappingObject)));

            PropertyNameConverters.Insert(0, new FuncToTypeListItem<MappingPair>(NativeProjectFieldsToCamelCasePropertyNameConverter.CanMap, typeof(NativeProjectFieldsToCamelCasePropertyNameConverter)));
        }
    }
}
