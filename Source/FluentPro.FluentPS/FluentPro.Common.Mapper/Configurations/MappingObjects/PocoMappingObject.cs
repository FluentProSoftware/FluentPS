using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FluentPro.Common.Mapper.Extensions;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Model;

namespace FluentPro.Common.Mapper.Configurations.MappingObjects
{
    public class PocoMappingObject : BaseMappingObject, IMappingSingleObject
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

        public override bool CanDiscoverProperties
        {
            get { return true; }
        }

        public override bool CanContainWhitespacesInProperties
        {
            get { return false; }
        }

        public override object UnderlyingObject
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
