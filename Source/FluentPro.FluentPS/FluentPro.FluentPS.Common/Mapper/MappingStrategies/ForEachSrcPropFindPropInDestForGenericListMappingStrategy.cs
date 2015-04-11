using FluentPro.FluentPS.Common.Mapper.Interfaces;
using System.Linq;
using System.Linq.Expressions;

namespace FluentPro.FluentPS.Common.Mapper.MappingStrategies
{
    public class ForEachSrcPropFindPropInDestForGenericListMappingStrategy : IMappingStrategy
    {
        public void Map<TSrc, TDest>(IMappingConfiguration ctx, TSrc src, TDest dest)
        {
            var srcWrapped = ctx.GetMappingSource(src);
            var destUnderlyingObjectType = typeof(TDest).GetGenericArguments()[0];

            var destPropsAccessor = ctx.GetPropsAccessor(destUnderlyingObjectType);

            var destProps = ctx
                .GetPropsResolver(destUnderlyingObjectType)
                .GetProperties(ctx.ObjectResolver.CreateInstance(destUnderlyingObjectType))
                .ToArray();

            var srcPropsAccessor = ctx.GetPropsAccessor(typeof(TSrc));
            var srcProps = ctx.GetPropsResolver(typeof(TSrc)).GetProperties(src).ToArray();

            while (srcWrapped.Next())
            {
                var obj = ctx.ObjectResolver.CreateInstance(destUnderlyingObjectType);
                foreach (var prop in srcProps)
                {
                    var convertedName = ctx.PropertyNameConverter.GetName(prop.Name);
                    var propInfo = destProps.FirstOrDefault(p => p.Name == convertedName);
                    if (propInfo != null)
                    {
                        var srcVal = srcPropsAccessor.GetPropertyValue(srcWrapped.Current, prop.Name);
                        destPropsAccessor.SetPropertyValue(obj, convertedName, srcVal);
                    }
                }

                typeof(TDest)
                    .GetMethod("Add")
                    .Invoke(dest, new object[] { obj });
            }
        }
    }
}
