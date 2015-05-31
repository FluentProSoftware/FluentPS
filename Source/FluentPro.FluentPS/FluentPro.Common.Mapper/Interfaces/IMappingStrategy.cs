using FluentPro.Common.Mapper.Types;

namespace FluentPro.Common.Mapper.Interfaces
{
    public interface IMappingStrategy
    {
        ////TODO: Implement format conversion to support native project server formats, may be do it with callback from existing strategy or sepparate property e.g. 
        /// IValueConverter which will know how to handle field conversion by name, type etc.
        IPropertyNameConverter PropertyNameConverter { get; set; }
        IPropertyValueConverter PropertyValueConverter { get; set; }
        IMappingConfiguration MapperConfiguration { get; set; }

        void Map(MappingPair mappingPair);

        // It is suggested to implement following method as part of a strategy
        // public static bool CanMap(MappingPair mappingObjects);
    }
}
