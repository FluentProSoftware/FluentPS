using System;
using System.Runtime.Serialization;

namespace FluentPro.Common.Mapper.Exceptions
{
    [Serializable]
    public class MissingMappingStrategyException : Exception
    {
        public Type Src { get; set; }

        public Type Dest { get; set; }

        public MissingMappingStrategyException()
        {
        }

        public MissingMappingStrategyException(string message)
            : base(message)
        {
        }

        public MissingMappingStrategyException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected MissingMappingStrategyException(
            SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
        }
    }
}
