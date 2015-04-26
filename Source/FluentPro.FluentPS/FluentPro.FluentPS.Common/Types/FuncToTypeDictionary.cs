using FluentPro.FluentPS.Common.Mapper.Exceptions;
using System;
using System.Collections.Generic;

namespace FluentPro.FluentPS.Common.Types
{
    public class FuncToTypeDictionary<T> : Dictionary<Func<T, bool>, Type>
    {
        public Type Get(T obj)
        {
            foreach (var item in this)
            {
                if (item.Key(obj))
                {
                    return item.Value;
                }
            }

            throw new MissingMappingWrapperException("Missing type for object.")
            {
                Object = obj
            };
        }
    }
}
