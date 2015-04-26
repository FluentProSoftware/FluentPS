using FluentPro.FluentPS.Common.Mapper.Types;

namespace FluentPro.FluentPS.Common.Mapper.Interfaces
{
    public interface IMappingStrategy
    {
        IPropertyNameConverter PropertyNameConverter { get; set; }
        IMappingConfiguration MapperConfiguration { get; set; }

        void Map(MappingPair mappingPair);
        
        // It is suggested to implement following method as part of a strategy
        // public static bool CanMap(MappingPair mappingObjects);
    }
}
