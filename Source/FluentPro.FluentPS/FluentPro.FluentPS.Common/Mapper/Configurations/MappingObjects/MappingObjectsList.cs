using FluentPro.FluentPS.Common.Extensions;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace FluentPro.FluentPS.Common.Mapper.Configurations.MappingObjects
{
    public class MappingObjectsList : IMappingEnumerableObject
    {
        private IList _list;
        private IEnumerator _enumerator;

        public bool Next()
        {
            return _enumerator.MoveNext();
        }

        public void Add(object obj)
        {
            _list.Add(obj);
        }

        public object Current
        {
            get { return _enumerator.Current; }
        }

        public object UnderlyingObject
        {
            get { return _list; }
            set
            {
                _list = (IList)value;
                _enumerator = _list.GetEnumerator();
            }
        }

        public static bool IsValid(object obj)
        {
            return typeof(List<>).IsAssignableFromType(obj.GetType());
        }
    }
}
