using System;

namespace FluentPro.FluentPS.Common.Mapper.Exceptions
{
    [Serializable]
    public class MissingMappingWrapperException : Exception
    {
        public object Object { get; set; }

        public MissingMappingWrapperException() { }
        public MissingMappingWrapperException(string message) : base(message) { }
        public MissingMappingWrapperException(string message, Exception inner) : base(message, inner) { }
        protected MissingMappingWrapperException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
