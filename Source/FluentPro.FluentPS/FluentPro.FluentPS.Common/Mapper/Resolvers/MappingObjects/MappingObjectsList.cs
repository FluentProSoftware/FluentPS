using FluentPro.FluentPS.Common.Mapper.Interfaces;
using System.Collections.Generic;

namespace FluentPro.FluentPS.Common.Mapper.Resolvers.MappingObjects
{
    public class MappingObjectsList : IMappingEnumerableObject
    {
        private List<object> _list;

        public MappingObjectsList(List<object> list)
        {
            _list = list;
        }

        public void Add(IMappingSingleObject obj)
        {
            throw new System.NotImplementedException();
        }

        public bool Next()
        {
            throw new System.NotImplementedException();
        }

        public IMappingSingleObject Current
        {
            get { throw new System.NotImplementedException(); }
        }

        public object UnderlyingObject
        {
            get { return _list; }
            set { _list = (List<object>)value; }
        }

        public static bool IsValid(object obj)
        {
            return typeof(List<>).IsAssignableFrom(obj.GetType());
        }
    }
}
