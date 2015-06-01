using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using FluentPro.Common.Mapper.Configurations.MappingObjects;
using FluentPro.Common.Mapper.Exceptions;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Model;
using FluentPro.FluentPS.Constants;

namespace FluentPro.FluentPS.Mapper.MappingObjects
{
    public class CustomFieldsDataTableMappingObject : BaseMappingObject, IMappingSingleObject, IMappingEnumerableObject
    {
        private DataTable _dataTable;
        private int _rowIdx;

        public void New()
        {
            //var row = _dataTable.NewRow();
            //foreach (var col in _dataTable.Columns.Cast<DataColumn>().Where(c => !c.AllowDBNull && row[c.ColumnName] == DBNull.Value))
            //{
            //    if (col.DataType == typeof(string))
            //    {
            //        row[col.ColumnName] = string.Empty;
            //        continue;
            //    }

            //    row[col.ColumnName] = Activator.CreateInstance(col.DataType);
            //}

            //_dataTable.Rows.Add(row);
            //_rowIdx++;
        }

        public bool Next()
        {
            return ++_rowIdx < _dataTable.Rows.Count;
        }

        public object Current
        {
            get { throw new NotImplementedException(); }
        }

        public object this[string propName]
        {
            get
            {
                var customFieldsTable = GetCustomFieldsTable();
                var customFieldsMap = customFieldsTable.Rows
                    .Cast<DataRow>()
                    .ToDictionary(r => r["MD_PROP_NAME"], r => r);

                var propUid = customFieldsMap[propName]["MD_PROP_UID"];
                var propVal = _dataTable.Rows
                    .Cast<DataRow>()
                    .Where(r => r["MD_PROP_UID"].Equals(propUid))
                    .Select(r => r["TEXT_VALUE"])
                    .FirstOrDefault();

                return propVal;
            }
            set
            {
                var customFieldsTable = GetCustomFieldsTable();
                var customFieldsMap = customFieldsTable.Rows
                    .Cast<DataRow>()
                    .ToDictionary(r => r["MD_PROP_NAME"], r => r);

                var propUid = customFieldsMap[propName]["MD_PROP_UID"];
                var row = _dataTable.Rows.Cast<DataRow>().FirstOrDefault(r => r["MD_PROP_UID"].Equals(propUid));
                if (row == null)
                {
                    var dataRow = _dataTable.NewRow();
                    dataRow["MD_PROP_UID"] = propUid;
                    dataRow["PROJ_UID"] = ExternalData["PROJ_UID"];
                    dataRow["CUSTOM_FIELD_UID"] = Guid.NewGuid();
                    dataRow["TEXT_VALUE"] = value;
                    _dataTable.Rows.Add(dataRow);
                }
            }
        }

        public IEnumerable<MappingObjectPropInfo> Properties
        {
            get
            {
                var customFieldsTable = GetCustomFieldsTable();
                var fields = customFieldsTable.Rows
                    .Cast<DataRow>()
                    .Select(r => new MappingObjectPropInfo
                    {
                        Name = r["MD_PROP_NAME"].ToString(),
                        Type = typeof(string)
                    })
                    .ToList();

                return fields;
            }
        }

        public override bool CanContainWhitespacesInProperties
        {
            get { return true; }
        }

        public override object UnderlyingObject
        {
            get { return _dataTable; }
            set { _dataTable = (DataTable)value; }
        }

        public static bool IsValid(object obj)
        {
            var dataTable = obj as DataTable;
            if (dataTable == null)
            {
                return false;
            }

            if (dataTable.TableName.EndsWith("CustomFields") && dataTable.TableName != "CustomFields")
            {
                return true;
            }

            return false;
        }

        private DataTable GetCustomFieldsTable()
        {
            if (!ExternalData.ContainsKey("CustomFieldDataSet"))
            {
                throw new ExternalDataRequiredException("Provide a CustomFieldDataSet object as external data for ProjectCustomFieldsDataTableMappingObject")
                {
                    DataKeyName = "CustomFieldDataSet"
                };
            }

            var customFieldsDs = ExternalData["CustomFieldDataSet"] as DataSet;
            var customFieldsTable = customFieldsDs.Tables["CustomFields"];

            return customFieldsTable;
        }
    }
}
