using FluentPro.FluentPS.Common.Constants;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using System.Data;
using FluentPro.FluentPS.Common.Extensions;

namespace FluentPro.FluentPS.Common.Mapper.MappingStrategies
{
    public class PsCustomFieldsToEntityMappingStrategy : IMappingStrategy
    {
        public IMappingConfiguration MappingConfiguration { get; set; }

        public bool CanMap<TSrc, TDest>()
        {
            if (!typeof(DataTable).IsAssignableFromType(typeof(TSrc)))
            {
                return false;
            }

            var instance = MappingConfiguration.ObjectResolver.CreateInstance<TSrc>() as DataTable;
            return instance.TableName == PsDataTableNames.ProjectCustomFields;
        }

        public void Map<TSrc, TDest>(TSrc src, TDest dest)
        {
            var customFieldsDataTable = src as DataTable;
            var reader = customFieldsDataTable.CreateDataReader();

            var srcPropsAccessor = MappingConfiguration.GetPropsAccessor(typeof(TSrc));
            var destPropsAccessor = MappingConfiguration.GetPropsAccessor(typeof(TDest));

            var projUid = destPropsAccessor.GetPropertyValue(src, "PROJ_UID");
        }
    }
}
