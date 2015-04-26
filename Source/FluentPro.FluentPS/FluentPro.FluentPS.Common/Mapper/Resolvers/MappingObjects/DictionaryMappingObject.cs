using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Model;
using System.Collections.Generic;
using System.Linq;
using FluentPro.FluentPS.Common.Extensions;

namespace FluentPro.FluentPS.Common.Mapper.Resolvers.MappingObjects
{
    public class DictionaryMappingObject : IMappingSingleObject
    {
        private Dictionary<string, object> _dict;

        public object this[string propName]
        {
            get
            {
                if (_dict.ContainsKey(propName))
                {
                    return _dict[propName];
                }

                return null;
            }
            set
            {
                if (!_dict.ContainsKey(propName))
                {
                    _dict.Add(propName, null);
                }

                _dict[propName] = value;
            }
        }

        public IEnumerable<MappingObjectPropInfo> Properties
        {
            get
            {
                return _dict.Keys.Select(key => new MappingObjectPropInfo
                {
                    Name = key,
                    Type = _dict[key].GetType()
                });
            }
        }

        public bool CanDiscoverProperties
        {
            get { return false; }
        }

        public object UnderlyingObject
        {
            get { return _dict; }
            set { _dict = (Dictionary<string, object>)value; }
        }

        public static bool IsValid(object obj)
        {
            return typeof(Dictionary<string, object>).IsAssignableFromType(obj.GetType());
        }
    }
}
