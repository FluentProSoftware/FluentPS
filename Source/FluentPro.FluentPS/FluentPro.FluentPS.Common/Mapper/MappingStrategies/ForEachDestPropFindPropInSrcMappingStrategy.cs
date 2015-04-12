using FluentPro.FluentPS.Common.Extensions;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using System.Linq;

namespace FluentPro.FluentPS.Common.Mapper.MappingStrategies
{
    public class ForEachDestPropFindPropInSrcMappingStrategy : IMappingStrategy
    {
        public IMappingConfiguration MappingConfiguration { get; set; }

        public bool CanMap<TSrc, TDest>()
        {
            return typeof(object).IsAssignableFromType(typeof(TSrc))
                && typeof(object).IsAssignableFromType(typeof(TDest));
        }

        public void Map<TSrc, TDest>(TSrc src, TDest dest)
        {
            var destPropsAccessor = MappingConfiguration.GetPropsAccessor(typeof(TDest));
            var destProps = MappingConfiguration.GetPropsResolver(typeof(TDest)).GetProperties(dest).ToArray();

            var srcPropsAccessor = MappingConfiguration.GetPropsAccessor(typeof(TSrc));
            var srcProps = MappingConfiguration.GetPropsResolver(typeof(TSrc)).GetProperties(src).ToArray();

            foreach (var prop in destProps)
            {
                var convertedName = MappingConfiguration.PropertyNameConverter.GetName(prop.Name);
                var propInfo = srcProps.FirstOrDefault(p => p.Name == convertedName);
                if (propInfo != null)
                {
                    var srcVal = srcPropsAccessor.GetPropertyValue(src, propInfo.Name);
                    destPropsAccessor.SetPropertyValue(dest, prop.Name, srcVal);
                }
            }
        }
    }
}
