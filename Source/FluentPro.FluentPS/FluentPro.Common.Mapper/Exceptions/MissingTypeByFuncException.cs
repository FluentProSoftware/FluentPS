using System;

namespace FluentPro.Common.Mapper.Exceptions
{
    [Serializable]
    public class MissingTypeByFuncException : Exception
    {
        public object Object { get; set; }

        public MissingTypeByFuncException() { }
        public MissingTypeByFuncException(string message) : base(message) { }
        public MissingTypeByFuncException(string message, Exception inner) : base(message, inner) { }
        protected MissingTypeByFuncException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
