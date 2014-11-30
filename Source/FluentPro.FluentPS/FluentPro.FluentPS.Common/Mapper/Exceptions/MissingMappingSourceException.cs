using System;
using System.Runtime.Serialization;

namespace FluentPro.FluentPS.Common.Mapper.Exceptions
{
    [Serializable]
    public class MissingMappingSourceException : Exception
    {
        public Type Src { get; set; }

        public MissingMappingSourceException()
        {
        }

        public MissingMappingSourceException(string message)
            : base(message)
        {
        }

        public MissingMappingSourceException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected MissingMappingSourceException(
            SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
        }
    }
}
