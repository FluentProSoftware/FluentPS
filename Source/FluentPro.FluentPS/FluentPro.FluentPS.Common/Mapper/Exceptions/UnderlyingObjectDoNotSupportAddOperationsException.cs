using System;

namespace FluentPro.FluentPS.Common.Mapper.Exceptions
{
    [Serializable]
    public class UnderlyingObjectDoNotSupportAddOperationsException : Exception
    {
        public Type UnderlyingObjectType { get; set; }

        public UnderlyingObjectDoNotSupportAddOperationsException() { }
        public UnderlyingObjectDoNotSupportAddOperationsException(string message) : base(message) { }
        public UnderlyingObjectDoNotSupportAddOperationsException(string message, Exception inner) : base(message, inner) { }
        protected UnderlyingObjectDoNotSupportAddOperationsException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
