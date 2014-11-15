using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Model;
using System.Linq;

namespace FluentPro.FluentPS.Common.Mapper.MappingStrategies
{
    public class ForEachSrcPropFindPropInDestMappingStrategy : IMappingStrategy
    {
        public void Map<TSrc, TDest>(MapperContext ctx, TSrc src, TDest dest)
        {
            var destPropsAccessor = ctx.GetPropsAccessor<TDest>();
            var destProps = ctx.GetPropsResolver<TDest>().GetProperties(dest).ToArray();

            var srcPropsAccessor = ctx.GetPropsAccessor<TSrc>();
            var srcProps = ctx.GetPropsResolver<TSrc>().GetProperties(src).ToArray();

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
