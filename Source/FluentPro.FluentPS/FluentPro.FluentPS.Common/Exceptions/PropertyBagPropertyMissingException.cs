using System;
using System.Runtime.Serialization;

namespace FluentPro.FluentPS.Common.Exceptions
{
    [Serializable]
    public class PropertyBagPropertyMissingException : Exception
    {
        public string PropertyName { get; private set; }

        public PropertyBagPropertyMissingException()
        {
        }

        public PropertyBagPropertyMissingException(string message)
            : base(message)
        {
        }

        public PropertyBagPropertyMissingException(string message, string propertyName)
            : base(message)
        {
            PropertyName = propertyName;
        }

        public PropertyBagPropertyMissingException(string message, Exception inner)
            : base(message, inner)
        {
        }

        public PropertyBagPropertyMissingException(string message, string propertyName, Exception inner)
            : base(message, inner)
        {
            PropertyName = propertyName;
        }

        protected PropertyBagPropertyMissingException(
            SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
        }
    }
}
