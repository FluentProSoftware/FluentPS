using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Model;

namespace FluentPro.Common.Mapper.Configurations.PropertyValueConverters
{
    public class NopPropertyValueConverter : IPropValueConverter
    {
        public object GetConvertedValue(MappingObjectPropInfo propInfo, MappingObjectPropInfo destPropInfo, object value)
        {
            return value;
        }
    }
}
