namespace FluentPro.FluentPS.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.All, Inherited = false)]
    public sealed class NameAttribute : Attribute
    {
        public NameAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
