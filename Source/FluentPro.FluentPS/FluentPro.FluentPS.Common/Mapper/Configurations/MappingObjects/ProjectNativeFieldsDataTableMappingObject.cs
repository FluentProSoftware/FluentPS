using FluentPro.FluentPS.Common.Constants;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FluentPro.FluentPS.Common.Mapper.Configurations.MappingObjects
{
    public class ProjectNativeFieldsDataTableMappingObject : BaseMappingObject, IMappingSingleObject, IMappingEnumerableObject
    {
        private DataTable _dataTable;
        private int _rowIdx;

        public bool Next()
        {
            if (_rowIdx < _dataTable.Rows.Count)
            {
                _rowIdx++;
                return true;
            }

            return false;
        }

        public void Add(object obj)
        {
            _dataTable.Rows.Add((DataRow)obj);
        }

        public object Current
        {
            get { return _dataTable.Rows[_rowIdx]; }
        }

        public override object UnderlyingObject
        {
            get { return _dataTable; }
            set { _dataTable = (DataTable)value; }
        }

        public object this[string propName]
        {
            get { return _dataTable.Rows[_rowIdx][propName]; }
            set { _dataTable.Rows[_rowIdx][propName] = value; }
        }

        public IEnumerable<MappingObjectPropInfo> Properties
        {
            get
            {
                return _dataTable.Columns.Cast<DataColumn>().Select(col => new MappingObjectPropInfo
                {
                    Name = col.ColumnName,
                    Type = col.DataType
                });
            }
        }

        public bool CanDiscoverProperties
        {
            get { return true; }
        }

        public static bool IsValid(object obj)
        {
            var dataTable = obj as DataTable;
            if (dataTable == null)
            {
                return false;
            }

            if (dataTable.TableName != PsDataTableNames.Project)
            {
                return false;
            }

            return true;
        }
    }
}
