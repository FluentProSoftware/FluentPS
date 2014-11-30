using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Model;
using System.Linq;

namespace FluentPro.FluentPS.Common.Mapper.MappingStrategies
{
    public class ForEachSrcPropAddOrSetPropInDestMappingStrategy : IMappingStrategy
    {
        public void Map<TSrc, TDest>(MapperContext ctx, TSrc src, TDest dest)
        {
            var destPropsAccessor = ctx.GetPropsAccessor(typeof(TDest));
            var srcPropsAccessor = ctx.GetPropsAccessor(typeof(TSrc));

            var srcProps = ctx.GetPropsResolver(typeof(TSrc)).GetProperties(src).ToArray();
            foreach (var prop in srcProps)
            {
                var convertedName = ctx.PropertyNameConverter.GetName(prop.Name);
                var srcVal = srcPropsAccessor.GetPropertyValue(src, prop.Name);
                destPropsAccessor.SetPropertyValue(dest, convertedName, srcVal);
            }
        }
    }
}
