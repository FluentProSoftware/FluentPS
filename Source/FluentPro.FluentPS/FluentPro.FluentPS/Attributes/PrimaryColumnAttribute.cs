namespace FluentPro.FluentPS.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.All, Inherited = false)]
    public sealed class PrimaryColumnAttribute : Attribute
    {
        public PrimaryColumnAttribute(string primaryColumn)
        {
            PrimaryColumn = primaryColumn;
        }

        public string PrimaryColumn { get; private set; }
    }
}
