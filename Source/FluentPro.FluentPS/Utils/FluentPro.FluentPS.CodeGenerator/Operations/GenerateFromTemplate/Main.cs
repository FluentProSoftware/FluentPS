using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using FluentPro.FluentPS.Attributes;
using FluentPro.FluentPS.CodeGenerator.Operations.GenerateFromTemplate.Data;
using FluentPro.FluentPS.CodeGenerator.Operations.GenerateFromTemplate.Model;
using FluentPro.FluentPS.CodeGenerator.Operations.GenerateFromTemplate.Templates;
using FluentPro.FluentPS.Extensions;
using FluentPro.FluentPS.Model;
using FluentPro.FluentPS.Psi.Model.DataSets;

namespace FluentPro.FluentPS.CodeGenerator.Operations.GenerateFromTemplate
{
    public class Main : IOperation
    {
        private readonly Dictionary<PsEntityType, DataTable> _dataTables = new Dictionary<PsEntityType, DataTable>
        {
            { PsEntityType.Project, new ProjectDataSet.ProjectDataTable() },
            { PsEntityType.Resource, new ResourceDataSet.ResourcesDataTable() },
            { PsEntityType.Task, new ProjectDataSet.ProjectDataTable() },
            { PsEntityType.Assignment, new ProjectDataSet.AssignmentDataTable() }
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

            var sections = new List<NativeFieldsSectionInfo>();
            foreach (var dataTable in _dataTables)
            {
                var section = new NativeFieldsSectionInfo();
                section.Name = dataTable.Key.GetAttr<NameAttribute>().Name;
                foreach (DataColumn column in dataTable.Value.Columns)
                {
                    var fieldInfo = new PsFieldInfo
                    {
                        Origin = PsOrigin.PsiDataTable,
                        EntityType = dataTable.Key,
                        PsiName = column.ColumnName,
                        DataType = column.DataType,
                        Uid = Guid.Empty,
                        DisplayName = string.Empty,
                        DbName = string.Empty,
                        ConversionType = PsConversionType.Invalid,
                        FieldType = PsFieldType.Unknown,
                        IsUpdatable = false,
                        PropertyName = string.Empty
                    };

                    var dbFieldInfo = dbFields
                        .Where(f => f.EntityType == dataTable.Key)
                        .FirstOrDefault(f => f.PsiName == column.ColumnName);
                    if (dbFieldInfo != null)
                    {
                        fieldInfo.Origin = PsOrigin.Database;
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

                        fieldInfo.FieldType = dbFieldInfo.FieldType;
                        fieldInfo.ConversionType = dbFieldInfo.ConversionType;
                    }

                    var userDefined = PredefinedFieldInfos.Overrides
                        .Where(f => f.EntityType == dataTable.Key)
                        .FirstOrDefault(f => f.PsiName == column.ColumnName);
                    if (userDefined != null)
                    {
                        fieldInfo.Origin = PsOrigin.Manual;
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

                    fieldInfo.PropertyName = GetPropertyName(column.ColumnName);
                    section.Fields.Add(fieldInfo);
                }

                var fieldsToAdd = PredefinedFieldInfos.Additional
                    .Where(f => f.EntityType == dataTable.Key)
                    .ToList();

                section.Fields.AddRange(fieldsToAdd);
                sections.Add(section);
            }

            var template = new NativeFieldsListTemplate
            {
                Session = new Dictionary<string, object>
                {
                    {"sections", sections }
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
                        EntityType = EnumExtensions.GetByAttr<PsEntityType, GuidAttribute>(attr => attr.Guid == (Guid)rdr["EntityUid"]),
                        Uid = (Guid)rdr["Uid"],
                        PsiName = GetValueOrDefault(rdr["PsiName"], string.Empty),
                        DbName = GetValueOrDefault(rdr["DbName"], string.Empty),
                        DisplayName = GetValueOrDefault(rdr["DisplayName"], string.Empty),
                        ConversionType = (PsConversionType)rdr["ConversionType"],
                        FieldType = (PsFieldType)rdr["FieldType"],
                        Origin = PsOrigin.Database
                    };

                    fields.Add(fieldInfo);
                }
            }

            return fields;
        }

        private string GetPropertyName(string sourceName)
        {
            var sb = new StringBuilder();
            sb.Append(sourceName[0]);
            for (var i = 1; i < sourceName.Length; i++)
            {
                var x = sourceName[i];
                if (x == '_')
                {
                    i++;
                    sb.Append(char.ToUpper(sourceName[i]));
                    continue;
                }

                if (char.IsUpper(x) && (char.IsLower(sourceName[i - 1]) || char.IsWhiteSpace(sourceName[i - 1])))
                {
                    sb.Append(x);
                    continue;
                }

                if (char.IsWhiteSpace(x))
                {
                    continue;
                }

                sb.Append(char.ToLower(x));
            }

            return sb.ToString();
        }

        private T GetValueOrDefault<T>(object obj, T defaultValue)
        {
            return obj == DBNull.Value ? defaultValue : (T)obj;
        }
    }
}
