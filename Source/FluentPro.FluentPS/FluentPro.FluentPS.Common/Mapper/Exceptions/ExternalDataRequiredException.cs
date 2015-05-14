using System;

namespace FluentPro.FluentPS.Common.Mapper.Exceptions
{
    [Serializable]
    public class ExternalDataRequiredException : Exception
    {
        public string DataKeyName { get; set; }

        public ExternalDataRequiredException() { }
        public ExternalDataRequiredException(string message) : base(message) { }
        public ExternalDataRequiredException(string message, Exception inner) : base(message, inner) { }
        protected ExternalDataRequiredException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
