using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Model;

namespace FluentPro.Common.Mapper.Configurations.PropertyValueConverters
{
    public class NopPropertyValueConverter : IPropertyValueConverter
    {
        public object GetValue(MappingObjectPropInfo propInfo, object value)
        {
            return value;
        }
    }
}
