using System;

namespace FluentPro.Common.Mapper.Interfaces
{
    public interface IMappingObjectFactory
    {
        object CreateInstance(Type type);
    }
}
