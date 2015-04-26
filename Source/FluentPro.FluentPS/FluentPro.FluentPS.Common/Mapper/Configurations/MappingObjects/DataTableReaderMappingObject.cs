using FluentPro.FluentPS.Common.Extensions;
using FluentPro.FluentPS.Common.Mapper.Exceptions;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Model;
using System.Collections.Generic;
using System.Data;

namespace FluentPro.FluentPS.Common.Mapper.Configurations.MappingObjects
{
    public class DataTableReaderMappingObject : IMappingSingleObject, IMappingEnumerableObject
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

        public bool CanDiscoverProperties
        {
            get { return true; }
        }

        public object UnderlyingObject
        {
            get { return _reader; }
            set { _reader = (DataTableReader)value; }
        }

        public static bool IsValid(object obj)
        {
            return typeof(DataTableReader).IsAssignableFromType(obj.GetType());
        }

        public void Add(object obj)
        {
            throw new UnderlyingObjectDoNotSupportAddOperationsException
            {
                UnderlyingObjectType = typeof(DataTableReader)
            };
        }

        public bool Next()
        {
            return _reader.Read();
        }

        public object Current
        {
            get { return _reader; }
        }
    }
}
