using System;
using System.Collections.Generic;
using FluentPro.Common.Mapper.Exceptions;

namespace FluentPro.Common.Mapper.Types
{
    public class FuncToTypeList<T> : List<FuncToTypeListItem<T>>
    {
        public Type Get(T obj)
        {
            foreach (var item in this)
            {
                if (item.Func(obj))
                {
                    return item.Value;
                }
            }

            throw new MissingTypeByFuncException("Missing type for object.")
            {
                Object = obj
            };
        }
    }

    public class FuncToTypeListItem<T>
    {
        public FuncToTypeListItem(Func<T, bool> func, Type value)
        {
            Func = func;
            Value = value;
        }

        public Func<T, bool> Func { get; private set; }
        public Type Value { get; private set; }
    }
}
