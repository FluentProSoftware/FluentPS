using FluentPro.FluentPS.Common.Mapper.Converters.PropertyNameConverters;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.MappingStrategies;
using FluentPro.FluentPS.Common.Mapper.Model;
using FluentPro.FluentPS.Common.Mapper.Resolvers.ObjectResolvers;
using FluentPro.FluentPS.Common.Mapper.Resolvers.PropertiesAccessors;
using FluentPro.FluentPS.Common.Mapper.Resolvers.PropertiesResolvers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace FluentPro.FluentPS.Common.Mapper
{
    /// <summary>
    /// FluentMapper provides core functionality for mapping between objects.
    /// </summary>
    public class FluentMapper
    {
        #region Constructors

        /// <summary>
        /// Initializes the <see cref="FluentMapper"/> class. Invoked when type accessed for the first time. All global default settings should reside here.
        /// </summary>
        static FluentMapper()
        {
            DefaultObjectResolver = new ActivatorObjectResolver();
            DefaultPropertyNameConverter = new RemoveWhiteSpacesPropertyNameConverter();

            DefaultPropertiesResolvers = new Dictionary<Type, IPropertiesResolver>
            {
                {typeof(IDictionary), new DictionaryPropertiesResolver()},
                {typeof(DataTableReader), new DataTableReaderPropertiesResolver()},
                {typeof(object), new PocoPropertiesResolver() }
            };

            DefaultPropertiesAccessors = new Dictionary<Type, IPropertiesAccessor>
            {
                {typeof(IDictionary), new DictionaryPropertiesAccessor()},
                {typeof(DataTableReader), new DataTableReaderPropertiesAccessor() },
                {typeof(object), new PocoPropertiesAccessor() }
            };

            //DataTable -> object = DestProps
            //object -> object = DestProps
            //object -> DataTable = SrcProps
            //DataTable -> Dict = SrcProps
            //Dict -> DataTable = SrcProps
            DefaultMappingStrategies = new Dictionary<Type, Dictionary<Type, IMappingStrategy>>
            {
                { 
                    typeof(DataTableReader), new Dictionary<Type, IMappingStrategy>
                    {
                        { typeof(Dictionary<string, object>), new ForEachSrcPropFindPropInDestMappingStrategy() },
                        { typeof(object), new ForEachDestPropFindPropInSrcMappingStrategy() }
                    }
                },

                {
                    typeof(object), new Dictionary<Type, IMappingStrategy>
                    {
                        { typeof(Dictionary<string, object>), new ForEachSrcPropFindPropInDestMappingStrategy() },
                        { typeof(object), new ForEachDestPropFindPropInSrcMappingStrategy() }
                    }
                }
            };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentMapper" /> class.
        /// Invoked by FluentMapper factory. Should not be invoked directly.
        /// </summary>
        /// <param name="objectResolver">The object resolver.</param>
        /// <param name="namingConvention">The naming convention.</param>
        /// <param name="mappingStrategy">The mapping strategy.</param>
        /// <param name="propertiesResolvers">The properties resolvers.</param>
        /// <param name="propertiesAccessors">The properties accessors.</param>
        /// <param name="mappingStrategies">The mapping strategies.</param>
        private FluentMapper(
            IObjectResolver objectResolver,
            IPropertyNameConverter namingConvention,
            IMappingStrategy mappingStrategy,
            Dictionary<Type, IPropertiesResolver> propertiesResolvers,
            Dictionary<Type, IPropertiesAccessor> propertiesAccessors,
            Dictionary<Type, Dictionary<Type, IMappingStrategy>> mappingStrategies)
        {
            MappingStrategies = mappingStrategies;
            MappingStrategy = mappingStrategy;
            PropertiesAccessors = propertiesAccessors;
            PropertiesResolvers = propertiesResolvers;
            PropertyNameConverter = namingConvention;
            ObjectResolver = objectResolver;
        }

        #endregion // Constructors

        #region Defaults

        /// <summary>
        /// Gets or sets the default object resolver.
        /// </summary>
        /// <value>
        /// The default object resolver.
        /// </value>
        public static IObjectResolver DefaultObjectResolver { get; set; }

        /// <summary>
        /// Gets or sets the default naming convention.
        /// </summary>
        /// <value>
        /// The default naming convention.
        /// </value>
        public static IPropertyNameConverter DefaultPropertyNameConverter { get; set; }

        /// <summary>
        /// Gets or sets the default mapping strategy.
        /// </summary>
        /// <value>
        /// The default mapping strategy.
        /// </value>
        public static IMappingStrategy DefaultMappingStrategy { get; set; }

        /// <summary>
        /// Gets or sets the default properties resolvers.
        /// </summary>
        /// <value>
        /// The default properties resolvers.
        /// </value>
        public static Dictionary<Type, IPropertiesResolver> DefaultPropertiesResolvers { get; set; }

        /// <summary>
        /// Gets or sets the default properties accessors.
        /// </summary>
        /// <value>
        /// The default properties accessors.
        /// </value>
        public static Dictionary<Type, IPropertiesAccessor> DefaultPropertiesAccessors { get; set; }

        /// <summary>
        /// Gets or sets the default mapping strategies.
        /// </summary>
        /// <value>
        /// The default mapping strategies.
        /// </value>
        public static Dictionary<Type, Dictionary<Type, IMappingStrategy>> DefaultMappingStrategies { get; set; }

        #endregion // Defaults

        #region Instance properties

        /// <summary>
        /// Gets the object resolver.
        /// </summary>
        /// <value>
        /// The object resolver.
        /// </value>
        public IObjectResolver ObjectResolver { get; private set; }

        /// <summary>
        /// Gets the naming convention.
        /// </summary>
        /// <value>
        /// The naming convention.
        /// </value>
        public IPropertyNameConverter PropertyNameConverter { get; private set; }

        /// <summary>
        /// Gets the mapping strategy.
        /// </summary>
        /// <value>
        /// The mapping strategy.
        /// </value>
        public IMappingStrategy MappingStrategy { get; private set; }

        /// <summary>
        /// Gets the properties resolvers.
        /// </summary>
        /// <value>
        /// The properties resolvers.
        /// </value>
        public Dictionary<Type, IPropertiesResolver> PropertiesResolvers { get; private set; }

        /// <summary>
        /// Gets the properties accessors.
        /// </summary>
        /// <value>
        /// The properties accessors.
        /// </value>
        public Dictionary<Type, IPropertiesAccessor> PropertiesAccessors { get; private set; }

        /// <summary>
        /// Gets the mapping strategies.
        /// </summary>
        /// <value>
        /// The mapping strategies.
        /// </value>
        public Dictionary<Type, Dictionary<Type, IMappingStrategy>> MappingStrategies { get; private set; }

        #endregion // Instance properties

        #region Factory props and methods

        /// <summary>
        /// Gets the current FluentMapper.
        /// </summary>
        /// <value>
        /// The current FluentMapper.
        /// </value>
        public static FluentMapper Default
        {
            get { return FluentMapperContainer.DefaultInstance; }
        }

        /// <summary>
        /// Creates new FluentMapper instance.
        /// </summary>
        /// <param name="objectResolver">The object resolver.</param>
        /// <param name="namingConvention">The naming convention.</param>
        /// <param name="mappingStrategy">The mapping strategy.</param>
        /// <param name="propertiesResolvers">The properties resolvers.</param>
        /// <param name="propertiesAccessors">The properties accessors.</param>
        /// <param name="mappingStrategies">The mapping strategies.</param>
        /// <returns>
        /// The new instance of FluentMapper.
        /// </returns>
        public static FluentMapper New(
            IObjectResolver objectResolver,
            IPropertyNameConverter namingConvention,
            IMappingStrategy mappingStrategy,
            Dictionary<Type, IPropertiesResolver> propertiesResolvers,
            Dictionary<Type, IPropertiesAccessor> propertiesAccessors,
            Dictionary<Type, Dictionary<Type, IMappingStrategy>> mappingStrategies)
        {
            return new FluentMapper(objectResolver, namingConvention, mappingStrategy, propertiesResolvers, propertiesAccessors, mappingStrategies);
        }

        #endregion // Factory props and methods

        #region Mapping methods

        public TDest Map<TSrc, TDest>(TSrc src)
        {
            var dest = ObjectResolver.CreateInstance<TDest>();

            var ctx = new MapperContext(PropertyNameConverter, ObjectResolver, PropertiesAccessors, PropertiesResolvers);
            var strategy = new ForEachSrcPropFindPropInDestMappingStrategy();
            strategy.Map(ctx, src, dest);
            return dest;
        }

        #endregion // Mapping methods

        #region Private methods

        #endregion // Private methods

        #region Nested classes

        private class FluentMapperContainer
        {
            static FluentMapperContainer() { }

            internal static readonly FluentMapper DefaultInstance = new FluentMapper(
                DefaultObjectResolver,
                DefaultPropertyNameConverter,
                DefaultMappingStrategy,
                DefaultPropertiesResolvers,
                DefaultPropertiesAccessors,
                DefaultMappingStrategies);
        }

        #endregion // Nested classes
    }
}
