using System;

namespace FluentPro.FluentPS.Common.Mapper.Interfaces
{
    public interface IMappingEnumerableObject : IMappingObject
    {
        bool Next();
        void Add(object obj);
        object Current { get; }
    }
}
