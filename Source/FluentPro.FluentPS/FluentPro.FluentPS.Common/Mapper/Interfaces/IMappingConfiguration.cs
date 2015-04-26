using FluentPro.FluentPS.Common.Mapper.Types;

namespace FluentPro.FluentPS.Common.Mapper.Interfaces
{
    public interface IMappingConfiguration
    {
        IMappingObjectFactory ObjectFactory { get; }

        FuncToTypeDictionary<object> MappingObjects { get; }
        FuncToTypeDictionary<MappingPair> MappingStrategies { get; }        
        FuncToTypeDictionary<MappingPair> PropertyNameConverters { get; }
    }
}
