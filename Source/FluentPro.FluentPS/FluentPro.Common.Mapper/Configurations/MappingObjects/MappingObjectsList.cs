using System.Collections;
using System.Collections.Generic;
using FluentPro.Common.Mapper.Extensions;
using FluentPro.Common.Mapper.Interfaces;

namespace FluentPro.Common.Mapper.Configurations.MappingObjects
{
    public class MappingObjectsList : BaseMappingObject, IMappingEnumerableObject
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

        public override object UnderlyingObject
        {
            get { return _list; }
            set
            {
                _list = (IList)value;
                _enumerator = _list.GetEnumerator();
            }
        }

        public override bool CanDiscoverProperties
        {
            get { return true; }
        }

        public override bool CanContainWhitespacesInProperties
        {
            get { return false; }
        }

        public static bool IsValid(object obj)
        {
            return typeof(List<>).IsAssignableFromType(obj.GetType());
        }
    }
}
