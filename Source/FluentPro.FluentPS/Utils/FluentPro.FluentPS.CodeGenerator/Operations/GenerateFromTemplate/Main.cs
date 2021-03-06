﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using FluentPro.FluentPS.Attributes;
using FluentPro.FluentPS.CodeGenerator.Operations.GenerateFromTemplate.Data;
using FluentPro.FluentPS.CodeGenerator.Operations.GenerateFromTemplate.Templates;
using FluentPro.FluentPS.Extensions;
using FluentPro.FluentPS.Model;
using FluentPro.FluentPS.Psi.Model.DataSets;

namespace FluentPro.FluentPS.CodeGenerator.Operations.GenerateFromTemplate
{
    public class Main : IOperation
    {
        /// <summary>
        /// The list of datatable to process, only non-custom fields datatables here.
        /// </summary>
        private readonly List<DataTable> _dataTables = new List<DataTable>
        {
            new ProjectDataSet.ProjectDataTable(),
            new ProjectDataSet.ProjectResourceDataTable(),
            new ProjectDataSet.AssignmentDataTable(),
            new ProjectDataSet.TaskDataTable(),
            new ResourceDataSet.ResourcesDataTable(),
            new ProjectTeamDataSet.ProjectTeamDataTable(),

            new CustomFieldDataSet.CustomFieldsDataTable()
        };

        public void Help()
        {
            Console.WriteLine("<Template>   : Template name to use.");
            Console.WriteLine("<Output>     : Output file name.");
            Console.WriteLine();

            Console.WriteLine("Templates    : NativeFieldsList");
        }

        public void Run(string[] args)
        {
            var dbFields = GetDbFieldInfos();

            var fields = new List<PsFieldInfo>();
            foreach (var dataTable in _dataTables)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    var fieldInfo = new PsFieldInfo
                    {
                        PsName = column.ColumnName,
                        TableName = column.Table.TableName ?? string.Empty,
                        DataType = column.DataType,
                        Uid = Guid.Empty,
                        DisplayName = string.Empty,
                        DbName = string.Empty,
                        PsDataType = PsDataType.Invalid,
                        IsUpdatable = false
                    };

                    var dbFieldInfo = dbFields
                        .Where(f => f.TableName == dataTable.TableName)
                        .FirstOrDefault(f => f.PsName == column.ColumnName);

                    if (dbFieldInfo != null)
                    {
                        if (fieldInfo.Uid == Guid.Empty)
                        {
                            fieldInfo.Uid = dbFieldInfo.Uid;
                        }

                        if (string.IsNullOrEmpty(fieldInfo.DisplayName))
                        {
                            fieldInfo.DisplayName = dbFieldInfo.DisplayName;
                        }

                        if (string.IsNullOrEmpty(fieldInfo.DbName))
                        {
                            fieldInfo.DbName = dbFieldInfo.DbName;
                        }

                        fieldInfo.PsDataType = dbFieldInfo.PsDataType;
                        fieldInfo.PsDataType = dbFieldInfo.PsDataType;
                    }

                    var userDefined = PredefinedFieldInfos.Overrides
                        .Where(f => f.TableName == dataTable.TableName)
                        .FirstOrDefault(f => f.PsName == column.ColumnName);

                    if (userDefined != null)
                    {
                        if (string.IsNullOrEmpty(fieldInfo.DbName))
                        {
                            fieldInfo.DbName = userDefined.DbName;
                        }

                        if (string.IsNullOrEmpty(fieldInfo.DisplayName))
                        {
                            fieldInfo.DisplayName = userDefined.DisplayName;
                        }

                        if (fieldInfo.DataType == null)
                        {
                            fieldInfo.DataType = userDefined.DataType;
                        }

                        fieldInfo.IsUpdatable = userDefined.IsUpdatable;
                    }

                    if (fieldInfo.PsDataType == PsDataType.FinishDate || fieldInfo.PsDataType == PsDataType.StartDate)
                    {
                        fieldInfo.PsDataType = PsDataType.Date;
                    }

                    fields.Add(fieldInfo);
                }
            }

            fields.AddRange(PredefinedFieldInfos.Additional);

            var template = new NativeFieldsListTemplate
            {
                Session = new Dictionary<string, object>
                {
                    {"fields", fields }
                }
            };

            var code = template.TransformText();
            Console.WriteLine(code);

            File.WriteAllText(args[2], code);
        }

        private List<PsFieldInfo> GetDbFieldInfos()
        {
            var connStringSb = new SqlConnectionStringBuilder
            {
                DataSource = ".",
                InitialCatalog = "pwa_ProjectWebApp",
                IntegratedSecurity = true
            };

            var fields = new List<PsFieldInfo>();
            using (var sqlConnection = new SqlConnection(connStringSb.ConnectionString))
            {
                sqlConnection.Open();

                var cmd = sqlConnection.CreateCommand();
                cmd.CommandText = @"
                            SELECT
        	                    WTABLE_UID as EntityUid,
        	                    WFIELD_UID as Uid,
        	                    WFIELD_NAME_SQL as PsiName,
        	                    WFIELD_NAME_OLEDB as DbName,
        	                    CONV_STRING as DisplayName,
        	                    WFIELD_TEXTCONV_TYPE as ConversionType,
        	                    WFIELD_IS_CUSTOM_FIELD as FieldType
                            FROM pub.MSP_WEB_VIEW_FIELDS VF 
        	                    LEFT JOIN pub.MSP_WEB_CONVERSIONS CV ON VF.WFIELD_NAME_CONV_VALUE = CV.CONV_VALUE
                            WHERE 
        	                    --WFIELD_IS_CUSTOM_FIELD = 0 AND
        	                    WTABLE_UID IS NOT NULL
                            ORDER BY 
        	                    EntityUid, PsiName";

                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var fieldInfo = new PsFieldInfo
                    {
                        TableName = EnumExtensions
                            .GetByAttr<PsEntityType, GuidAttribute>(attr => attr.Guid == (Guid)rdr["EntityUid"])
                            .GetAttr<NameAttribute>()
                            .Name,

                        Uid = (Guid)rdr["Uid"],
                        PsName = GetValueOrDefault(rdr["PsiName"], string.Empty),
                        DbName = GetValueOrDefault(rdr["DbName"], string.Empty),
                        DisplayName = GetValueOrDefault(rdr["DisplayName"], string.Empty),
                        PsDataType = (PsDataType)rdr["ConversionType"]
                    };

                    fields.Add(fieldInfo);
                }
            }

            return fields;
        }

        private T GetValueOrDefault<T>(object obj, T defaultValue)
        {
            return obj == DBNull.Value ? defaultValue : (T)obj;
        }
    }
}
