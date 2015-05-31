using FluentPro.Common.Mapper.Model;

namespace FluentPro.Common.Mapper.Interfaces
{
    public interface IPropertyValueConverter
    {
        object GetValue(MappingObjectPropInfo propInfo, object value);
    }
}
