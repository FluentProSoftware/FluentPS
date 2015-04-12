using FluentPro.FluentPS.Common.Extensions;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using System.Data;
using System.Linq;

namespace FluentPro.FluentPS.Common.Mapper.MappingStrategies
{
    /// <summary>
    /// For each property in source, find a property in destination and copy value from source to destination. 
    /// If there is no such property in destination - do nothing.
    /// </summary>
    public class ForEachSrcPropFindPropInDestMappingStrategy : IMappingStrategy
    {
        public IMappingConfiguration MappingConfiguration { get; set; }

        public bool CanMap<TSrc, TDest>()
        {
            return typeof(DataTableReader).IsAssignableFromType(typeof(TSrc))
                && typeof(object).IsAssignableFromType(typeof(TDest));
        }

        public void Map<TSrc, TDest>(TSrc src, TDest dest)
        {
            var destPropsAccessor = MappingConfiguration.GetPropsAccessor(typeof(TDest));
            var destProps = MappingConfiguration.GetPropsResolver(typeof(TDest)).GetProperties(dest).ToArray();

            var srcPropsAccessor = MappingConfiguration.GetPropsAccessor(typeof(TSrc));
            var srcProps = MappingConfiguration.GetPropsResolver(typeof(TSrc)).GetProperties(src).ToArray();

            foreach (var prop in srcProps)
            {
                var convertedName = MappingConfiguration.PropertyNameConverter.GetName(prop.Name);
                var propInfo = destProps.FirstOrDefault(p => p.Name == convertedName);
                if (propInfo != null)
                {
                    var srcVal = srcPropsAccessor.GetPropertyValue(src, prop.Name);
                    destPropsAccessor.SetPropertyValue(dest, convertedName, srcVal);
                }
            }
        }
    }
}
