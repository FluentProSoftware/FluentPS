using FluentPro.FluentPS.Common.Mapper.Configurations;
using FluentPro.FluentPS.Common.Mapper.Interfaces;

namespace FluentPro.FluentPS.Common.Mapper
{
    /// <summary>
    /// FluentMapper provides core functionality for mapping between objects.
    /// </summary>
    public class FluentMapper
    {
        public FluentMapper(IMappingConfiguration config)
        {
            MapperConfiguration = config;
        }

        public IMappingConfiguration MapperConfiguration { get; private set; }

        public static FluentMapper PsMapper
        {
            get { return FluentMapperContainer.PsMapperInstance; }
        }

        public static FluentMapper PlainMapper
        {
            get { return FluentMapperContainer.PlainMapper; }
        }

        public TDest Map<TSrc, TDest>(TSrc src)
        {
            var strategy = MapperConfiguration.GetMappingStrategy<TSrc, TDest>();
            var dest = MapperConfiguration.ObjectResolver.CreateInstance<TDest>();
            strategy.Map(MapperConfiguration, src, dest);
            return dest;
        }

        private class FluentMapperContainer
        {
            static FluentMapperContainer() { }

            internal static readonly FluentMapper PsMapperInstance = new FluentMapper(new PsMappingConfiguration());

            internal static readonly FluentMapper PlainMapper = new FluentMapper(new PlainMappingConfiguration());
        }
    }
}
