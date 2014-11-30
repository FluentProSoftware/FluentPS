using FluentPro.FluentPS.Common.Mapper.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FluentPro.FluentPS.Common.Mapper.Resolvers.MappingDestinations
{
    public class ListMappingDestination : IMappingDestination
    {
        private readonly List<object> _list;

        public ListMappingDestination(object list)
        {
            var en = (IEnumerable)list;
             _list = new List<object>(en.Cast<object>());
        }

        public void Add(object obj)
        {
            _list.Add(obj);
        }

        public object GetUnwrapedObject()
        {
            return _list;
        }
    }
}
