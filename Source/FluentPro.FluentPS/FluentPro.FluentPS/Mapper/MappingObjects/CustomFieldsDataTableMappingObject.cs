using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using FluentPro.Common.Mapper.Configurations.MappingObjects;
using FluentPro.Common.Mapper.Exceptions;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Model;
using FluentPro.FluentPS.Constants;
using FluentPro.FluentPS.Model;

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

        // TODO: Implement mapping to types different than decimal
        // Implement mapping Duration to TimeSpan
        // Implement mapping Work to TimeSpan
        // It shuld be done in value converter
        public object this[string propName]
        {
            get
            {
                var customFieldsTable = GetCustomFieldsTable();
                var customFieldsMap = customFieldsTable.Rows
                    .Cast<DataRow>()
                    .ToDictionary(r => r["MD_PROP_NAME"], r => r);

                var customField = customFieldsMap[propName];
                var propUid = customField["MD_PROP_UID"];

                // MD_PROP_TYPE_ENUM stored as byte internaly, we have to unbox it to byte first to convert to enum.
                var type = (PsConversionType)(byte)customField["MD_PROP_TYPE_ENUM"]; 
                var targetColumn = GetColumnNameByDataType(type);

                var row = _dataTable.Rows
                    .Cast<DataRow>()
                    .Where(r => r["PROJ_UID"].Equals(ExternalData["PROJ_UID"]))
                    .FirstOrDefault(r => r["MD_PROP_UID"].Equals(propUid));

                if (row == null)
                {
                    return null;
                }

                return row[targetColumn];
            }
            set
            {
                var customFieldsTable = GetCustomFieldsTable();
                var customFieldsMap = customFieldsTable.Rows
                    .Cast<DataRow>()
                    .ToDictionary(r => r["MD_PROP_NAME"], r => r);

                var customField = customFieldsMap[propName];

                var propUid = customField["MD_PROP_UID"];
                
                // MD_PROP_TYPE_ENUM stored as byte internaly, we have to unbox it to byte first to convert to enum.
                var type = (PsConversionType)(byte)customField["MD_PROP_TYPE_ENUM"]; 
                var targetColumn = GetColumnNameByDataType(type);

                var row = _dataTable.Rows.Cast<DataRow>().FirstOrDefault(r => r["MD_PROP_UID"].Equals(propUid));

                //If there are now row exists for given custom field value, create a new one.
                if (row == null && value != null)
                {
                    row = _dataTable.NewRow();
                    row["MD_PROP_UID"] = propUid;
                    row["PROJ_UID"] = ExternalData["PROJ_UID"];
                    row["CUSTOM_FIELD_UID"] = Guid.NewGuid();
                    row[targetColumn] = value;
                    _dataTable.Rows.Add(row);
                    return;
                }

                //If custom field value is null, remove the row with existing values, it will erase the field on server.
                if (row != null && value == null)
                {
                    _dataTable.Rows.Remove(row);
                    return;
                }

                //If row for given custom field value exists, update a value in column
                if (row != null)
                {
                    row[targetColumn] = value;
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

            if (dataTable.Namespace.Contains("http://schemas.microsoft.com/office/project/server") && dataTable.TableName.EndsWith("CustomFields") && dataTable.TableName != "CustomFields")
            {
                return true;
            }

            return false;
        }

        private string GetColumnNameByDataType(PsConversionType conversionType)
        {
            var dict = new Dictionary<PsConversionType, string>
            {
                { PsConversionType.Guid, "CODE_VALUE" },
                { PsConversionType.String, "TEXT_VALUE" },
                { PsConversionType.Cost, "NUM_VALUE" },
                { PsConversionType.Number, "NUM_VALUE" },
                { PsConversionType.Date, "DATE_VALUE" },
                { PsConversionType.YesNo, "FLAG_VALUE" },
                { PsConversionType.Duration, "DUR_VALUE" }
            };

            if (!dict.ContainsKey(conversionType))
            {
                throw new ArgumentOutOfRangeException("conversionType", "Conversion type not supported");
            }

            return dict[conversionType];
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
