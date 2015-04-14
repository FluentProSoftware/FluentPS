using FluentPro.FluentPS.Common.Mapper.Configurations;
using FluentPro.FluentPS.Common.Mapper.Interfaces;

namespace FluentPro.FluentPS.Common.Mapper
{
    /// <summary>
    /// FluentMapper provides core functionality for mapping between objects.
    /// </summary>
    public class FluentMapper
    {
        private readonly IMappingConfiguration mapperConfiguration;

        public FluentMapper(IMappingConfiguration config)
        {
            mapperConfiguration = config;
        }

        public static FluentMapper PsMapper
        {
            get { return FluentMapperContainer.PsMapper; }
        }

        public static FluentMapper PlainMapper
        {
            get { return FluentMapperContainer.PlainMapper; }
        }

        public TDest Map<TSrc, TDest>(TSrc src)
        {
            var dest = mapperConfiguration.ObjectResolver.CreateInstance<TDest>();
            Map(src, dest);
            return dest;
        }

        public void Map<TSrc, TDest>(TSrc src, TDest dest)
        {
            var strategy = mapperConfiguration.GetMappingStrategy<TSrc, TDest>();
            strategy.Map(src, dest);
        }

        private class FluentMapperContainer
        {
            static FluentMapperContainer() { }

            internal static readonly FluentMapper PsMapper = new FluentMapper(new PsMappingConfiguration());

            internal static readonly FluentMapper PlainMapper = new FluentMapper(new PlainMappingConfiguration());
        }
    }
}
