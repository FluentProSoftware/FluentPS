using System;

namespace FluentPro.FluentPS.Common.Mapper.Interfaces
{
    public interface IObjectResolver
    {
        T CreateInstance<T>();
        object CreateInstance(Type type);
    }
}
