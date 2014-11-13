using System;

namespace FluentPro.FluentPS.Common.Mapper.Exceptions
{
    [Serializable]
    public class MissingPropertyAccessorException : Exception
    {
        public Type Type { get; set; }

        public MissingPropertyAccessorException() { }
        public MissingPropertyAccessorException(string message) : base(message) { }
        public MissingPropertyAccessorException(string message, Exception inner) : base(message, inner) { }
        protected MissingPropertyAccessorException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
