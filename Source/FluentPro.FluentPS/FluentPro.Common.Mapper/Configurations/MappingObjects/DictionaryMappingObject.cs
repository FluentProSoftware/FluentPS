using System.Collections.Generic;
using System.Linq;
using FluentPro.Common.Mapper.Extensions;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Model;

namespace FluentPro.Common.Mapper.Configurations.MappingObjects
{
    public class DictionaryMappingObject : BaseMappingObject, IMappingSingleObject
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
                //TODO: Is it correct to asume type object when value is null? May be introduce special property or something.
                return _dict.Keys.Select(key => new MappingObjectPropInfo
                {
                    Name = key,
                    Type = _dict[key] == null ? typeof(object) : _dict[key].GetType()
                });
            }
        }

        public override bool CanContainWhitespacesInProperties
        {
            get { return true; }
        }

        public override object UnderlyingObject
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
