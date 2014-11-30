using System;
using System.Runtime.Serialization;

namespace FluentPro.FluentPS.Common.Mapper.Exceptions
{
    [Serializable]
    public class MissingMappingDestinationException : Exception
    {
        public Type Dest { get; set; }

        public MissingMappingDestinationException()
        {
        }

        public MissingMappingDestinationException(string message)
            : base(message)
        {
        }

        public MissingMappingDestinationException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected MissingMappingDestinationException(
            SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
        }
    }
}
