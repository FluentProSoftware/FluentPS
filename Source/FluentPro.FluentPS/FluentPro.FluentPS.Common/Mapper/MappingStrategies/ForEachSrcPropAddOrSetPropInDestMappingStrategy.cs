using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Model;
using System.Linq;

namespace FluentPro.FluentPS.Common.Mapper.MappingStrategies
{
    /// <summary>
    /// Find all properties in source and set them to target. It is used when mapping datareader to Dictionary.
    /// </summary>
    public class ForEachSrcPropAddOrSetPropInDestMappingStrategyWithSameName : IMappingStrategy
    {
        public void Map<TSrc, TDest>(IMappingConfiguration ctx, TSrc src, TDest dest)
        {
            var destPropsAccessor = ctx.GetPropsAccessor(typeof(TDest));
            var srcPropsAccessor = ctx.GetPropsAccessor(typeof(TSrc));

            var srcProps = ctx.GetPropsResolver(typeof(TSrc)).GetProperties(src).ToArray();
            foreach (var prop in srcProps)
            {
                var srcVal = srcPropsAccessor.GetPropertyValue(src, prop.Name);
                destPropsAccessor.SetPropertyValue(dest, prop.Name, srcVal);
            }
        }
    }
}
