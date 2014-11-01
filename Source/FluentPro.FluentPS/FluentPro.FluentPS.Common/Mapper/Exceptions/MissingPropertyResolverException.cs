using System;
using System.Runtime.Serialization;

namespace FluentPro.FluentPS.Common.Mapper.Exceptions
{
    [Serializable]
    public class MissingPropertyResolverException : Exception
    {
        public Type Type { get; set; }

        public MissingPropertyResolverException()
        {
        }

        public MissingPropertyResolverException(string message)
            : base(message)
        {
        }

        public MissingPropertyResolverException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected MissingPropertyResolverException(
            SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
        }
    }
}
