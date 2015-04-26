using FluentPro.FluentPS.Common.Types;

namespace FluentPro.FluentPS.Common.Mapper.Interfaces
{
    public interface IMappingConfiguration
    {
        IObjectResolver ObjectResolver { get; }

        FuncToTypeDictionary<object> MappingObjects { get; }
        FuncToTypeDictionary<MappingPair> MappingStrategies { get; }        
        FuncToTypeDictionary<MappingPair> PropertyNameConverters { get; }
    }
}
