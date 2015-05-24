namespace FluentPro.FluentPS.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.All, Inherited = false)]
    public sealed class GuidAttribute : Attribute
    {
        public GuidAttribute(string guid)
        {
            Guid = new Guid(guid);
        }

        public Guid Guid { get; private set; }
    }
}
