using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Model;
using System.Linq;

namespace FluentPro.FluentPS.Common.Mapper.MappingStrategies
{
    /// <summary>
    /// For each property in source, find a property in destination and copy value from source to destination. 
    /// If there is no such property in destination - do nothing.
    /// </summary>
    public class ForEachSrcPropFindPropInDestMappingStrategy : IMappingStrategy
    {
        public void Map<TSrc, TDest>(IMappingConfiguration ctx, TSrc src, TDest dest)
        {
            var destPropsAccessor = ctx.GetPropsAccessor(typeof(TDest));
            var destProps = ctx.GetPropsResolver(typeof(TDest)).GetProperties(dest).ToArray();

            var srcPropsAccessor = ctx.GetPropsAccessor(typeof(TSrc));
            var srcProps = ctx.GetPropsResolver(typeof(TSrc)).GetProperties(src).ToArray();

            foreach (var prop in srcProps)
            {
                var convertedName = ctx.PropertyNameConverter.GetName(prop.Name);
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
