using System.Collections.Generic;
using System.Data;
using System.Linq;
using FluentPro.Common.Mapper.Extensions;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Model;

namespace FluentPro.Common.Mapper.Configurations.MappingObjects
{
    public class DataRowMappingObject : BaseMappingObject, IMappingSingleObject
    {
        private DataRow _row;

        public object this[string propName]
        {
            get { return _row[propName]; }
            set { _row[propName] = value; }
        }

        public IEnumerable<MappingObjectPropInfo> Properties
        {
            get
            {
                return _row.Table.Columns.Cast<DataColumn>().Select(c => new MappingObjectPropInfo
                {
                    Name = c.ColumnName,
                    Type = c.DataType
                });
            }
        }

        public override bool CanContainWhitespacesInProperties
        {
            get { return true; }
        }

        public override object UnderlyingObject
        {
            get { return _row; }
            set { _row = (DataRow)value; }
        }

        public static bool IsValid(object obj)
        {
            return typeof(DataRow).IsAssignableFromType(obj.GetType());
        }
    }
}
