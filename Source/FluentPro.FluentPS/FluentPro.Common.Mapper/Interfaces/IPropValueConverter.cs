namespace FluentPro.Common.Mapper.Interfaces
{
    using Model;

    public interface IPropValueConverter
    {
        object GetConvertedValue(MappingObjectPropInfo sourcePropInfo, MappingObjectPropInfo destPropInfo, object value);
    }
}
