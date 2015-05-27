using System.Collections.Generic;
using System.Data;
using FluentPro.Common.Mapper.Exceptions;
using FluentPro.Common.Mapper.Extensions;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Model;

namespace FluentPro.Common.Mapper.Configurations.MappingObjects
{
    public class DataTableReaderMappingObject : BaseMappingObject, IMappingSingleObject, IMappingEnumerableObject
    {
        private DataTableReader _reader;

        public object this[string propName]
        {
            get { return _reader[propName]; }
            set { throw new UnderlyingObjectDoNotSupportSetOperationsException { UnderlyingObjectType = typeof(DataTableReader) }; }
        }

        public IEnumerable<MappingObjectPropInfo> Properties
        {
            get
            {
                for (var i = 0; i < _reader.FieldCount; i++)
                {
                    yield return new MappingObjectPropInfo
                    {
                        Name = _reader.GetName(i),
                        Type = _reader.GetFieldType(i)
                    };
                }
            }
        }

        public override bool CanDiscoverProperties
        {
            get { return true; }
        }

        public override bool CanContainWhitespacesInProperties
        {
            get { return true; }
        }

        public override object UnderlyingObject
        {
            get { return _reader; }
            set { _reader = (DataTableReader)value; }
        }

        public bool Next()
        {
            return _reader.Read();
        }

        public object New()
        {
            throw new UnderlyingObjectDoNotSupportAddOperationsException("DataTableReader do not support creation of new objects.")
            {
                UnderlyingObjectType = typeof(DataTableReader)
            };
        }

        public object Current
        {
            get { return _reader; }
        }

        public static bool IsValid(object obj)
        {
            return typeof(DataTableReader).IsAssignableFromType(obj.GetType());
        }
    }
}
