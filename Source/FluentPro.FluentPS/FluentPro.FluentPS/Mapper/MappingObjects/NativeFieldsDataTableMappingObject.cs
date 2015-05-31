using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using FluentPro.Common.Mapper.Configurations.MappingObjects;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Model;
using FluentPro.FluentPS.Constants;

namespace FluentPro.FluentPS.Mapper.MappingObjects
{
    public class NativeFieldsDataTableMappingObject : BaseMappingObject, IMappingSingleObject, IMappingEnumerableObject
    {
        private static readonly string[] SupportedTables = {
            PsDataTableNames.Project,
            PsDataTableNames.Task,
            PsDataTableNames.Assignment,
            PsDataTableNames.Resources,
            PsDataTableNames.ProjectTeam
        };

        private DataTable _dataTable;
        private int _rowIdx = -1;

        public void New()
        {
            var row = _dataTable.NewRow();
            foreach (var col in _dataTable.Columns.Cast<DataColumn>().Where(c => !c.AllowDBNull && row[c.ColumnName] == DBNull.Value))
            {
                if (col.DataType == typeof(string))
                {
                    row[col.ColumnName] = string.Empty;
                    continue;
                }

                row[col.ColumnName] = Activator.CreateInstance(col.DataType);
            }

            _dataTable.Rows.Add(row);
            _rowIdx++;
        }

        public bool Next()
        {
            return ++_rowIdx < _dataTable.Rows.Count;
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
            get { return Get(propName); }
            set { Set(propName, value); }
        }

        private object Get(string column)
        {
            if (_rowIdx == -1)
            {
                _rowIdx++;
            }

            return _dataTable.Rows[_rowIdx][column];
        }

        private void Set(string column, object value)
        {
            if (_rowIdx == -1)
            {
                New();
            }

            _dataTable.Rows[_rowIdx][column] = value;
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

        public override bool CanDiscoverProperties
        {
            get { return true; }
        }

        public override bool CanContainWhitespacesInProperties
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

            if (!SupportedTables.Contains(dataTable.TableName))
            {
                return false;
            }

            return true;
        }
    }
}
