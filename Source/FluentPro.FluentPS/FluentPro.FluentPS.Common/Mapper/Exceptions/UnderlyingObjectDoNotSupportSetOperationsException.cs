using System;

namespace FluentPro.FluentPS.Common.Mapper.Exceptions
{
    [Serializable]
    public class UnderlyingObjectDoNotSupportSetOperationsException : Exception
    {
        public Type UnderlyingObjectType { get; set; }

        public UnderlyingObjectDoNotSupportSetOperationsException() { }
        public UnderlyingObjectDoNotSupportSetOperationsException(string message) : base(message) { }
        public UnderlyingObjectDoNotSupportSetOperationsException(string message, Exception inner) : base(message, inner) { }
        protected UnderlyingObjectDoNotSupportSetOperationsException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
