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
    public class ProjectCustomFieldsDataTableMappingObject : BaseMappingObject, IMappingSingleObject, IMappingEnumerableObject
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

        public object Current
        {
            get { throw new NotImplementedException(); }
        }

        public object this[string propName]
        {
            get
            {
                //TODO: Test with two fields with the same name in different domains
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
                throw new NotImplementedException();
            }
        }

        public IEnumerable<MappingObjectPropInfo> Properties
        {
            get
            {
                var customFieldsTable = GetCustomFieldsTable();
                var customFieldsMap = customFieldsTable.Rows
                    .Cast<DataRow>()
                    .ToDictionary(r => r["MD_PROP_UID"], r => r);

                var props = new List<MappingObjectPropInfo>();
                foreach (var row in _dataTable.Rows.Cast<DataRow>())
                {
                    if (!customFieldsMap.ContainsKey(row[PsCustomFieldsColumnNames.MD_PROP_UID]))
                    {
                        continue;
                    }

                    var customFieldDefinition = customFieldsMap[row[PsCustomFieldsColumnNames.MD_PROP_UID]];
                    props.Add(new MappingObjectPropInfo
                    {
                        Name = customFieldDefinition["MD_PROP_NAME"].ToString(),
                        Type = typeof(string)
                    });
                }

                return props;
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

            if (dataTable.TableName != PsDataTableNames.ProjectCustomFields)
            {
                return false;
            }

            return true;
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


        public object New()
        {
            throw new NotImplementedException();
        }
    }
}
