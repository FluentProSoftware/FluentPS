using FluentPro.Common.Mapper.Types;

namespace FluentPro.Common.Mapper.Interfaces
{
    public interface IMappingStrategy
    {
        IPropsMatcher PropsMatcher { get; set; }
        IPropertyValueConverter PropertyValueConverter { get; set; }
        IMappingConfiguration MapperConfiguration { get; set; }

        void Map(MappingPair mappingPair);

        // It is suggested to implement following method as part of a strategy
        // public static bool CanMap(MappingPair mappingObjects);
    }
}
