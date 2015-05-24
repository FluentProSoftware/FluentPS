using System;
using System.Collections.Generic;

namespace FluentPro.FluentPS.Types
{
    public class GenericEqualityComparer<T> : IEqualityComparer<T>
    {
        private readonly Func<T, T, bool> _equalsFunction;
        private readonly Func<T, int> _getHashCodeFunction;

        public GenericEqualityComparer(Func<T, T, bool> equalsFunction)
        {
            _equalsFunction = equalsFunction;
        }

        public GenericEqualityComparer(Func<T, T, bool> equalsFunction, Func<T, int> getHashCodeFunction)
            : this(equalsFunction)
        {
            _getHashCodeFunction = getHashCodeFunction;
        }

        public bool Equals(T a, T b)
        {
            return _equalsFunction(a, b);
        }

        public int GetHashCode(T obj)
        {
            if (_getHashCodeFunction == null)
            {
                return obj.GetHashCode();
            }

            return _getHashCodeFunction(obj);
        }
    }
}
