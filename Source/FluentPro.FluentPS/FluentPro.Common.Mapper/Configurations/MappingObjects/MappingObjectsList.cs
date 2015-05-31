using System;
using System.Collections;
using System.Collections.Generic;
using FluentPro.Common.Mapper.Extensions;
using FluentPro.Common.Mapper.Interfaces;

namespace FluentPro.Common.Mapper.Configurations.MappingObjects
{
    public class MappingObjectsList : BaseMappingObject, IMappingEnumerableObject
    {
        private int _idx = -1;
        private IList _list;
        private Type _genericItemType;

        public bool Next()
        {
            return ++_idx < _list.Count;
        }

        public void New()
        {
            var item = Activator.CreateInstance(_genericItemType);
            _list.Add(item);
            _idx++;
        }

        public object Current
        {
            get { return _list[_idx]; }
        }

        public override object UnderlyingObject
        {
            get { return _list; }
            set
            {
                _list = (IList)value;
                _genericItemType = _list.GetType().GetGenericArguments()[0];
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
