using FluentPro.FluentPS.Common.Extensions;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Model;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FluentPro.FluentPS.Common.Mapper.Configurations.MappingObjects
{
    public class DataRowMappingObject : IMappingSingleObject
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

        public bool CanDiscoverProperties
        {
            get { return true; }
        }

        public object UnderlyingObject
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
