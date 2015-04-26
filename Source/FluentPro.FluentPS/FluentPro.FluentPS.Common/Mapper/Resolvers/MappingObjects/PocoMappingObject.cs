using FluentPro.FluentPS.Common.Extensions;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Model;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FluentPro.FluentPS.Common.Mapper.Resolvers.MappingObjects
{
    public class PocoMappingObject : IMappingSingleObject
    {
        private object _target;

        public object this[string propName]
        {
            get { return _target.GetType().GetProperty(propName).GetValue(_target, null); }
            set { _target.GetType().GetProperty(propName).SetValue(_target, value, null); }
        }

        public IEnumerable<MappingObjectPropInfo> Properties
        {
            get
            {
                return _target.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance).Select(p => new MappingObjectPropInfo
                {
                    Name = p.Name,
                    Type = p.PropertyType
                });
            }
        }

        public bool CanDiscoverProperties
        {
            get { return true; }
        }

        public object UnderlyingObject
        {
            get { return _target; }
            set { _target = value; }
        }

        public static bool IsValid(object obj)
        {
            return typeof(object).IsAssignableFromType(obj.GetType());
        }
    }
}
