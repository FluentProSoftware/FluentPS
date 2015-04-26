using System;

namespace FluentPro.FluentPS.Common.Mapper.Interfaces
{
    public interface IMappingObjectFactory
    {
        object CreateInstance(Type type);
    }
}
