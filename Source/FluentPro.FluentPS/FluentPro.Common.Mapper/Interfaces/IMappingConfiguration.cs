using FluentPro.Common.Mapper.Types;

namespace FluentPro.Common.Mapper.Interfaces
{
    public interface IMappingConfiguration
    {
        IMappingObjectFactory ObjectFactory { get; }

        FuncToTypeList<object> MappingObjects { get; }
        FuncToTypeList<MappingPair> MappingStrategies { get; }
        FuncToTypeList<MappingPair> PropertyNameConverters { get; }
    }
}
