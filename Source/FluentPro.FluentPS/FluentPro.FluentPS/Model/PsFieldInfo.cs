namespace FluentPro.FluentPS.Model
{
    using System;

    public class PsFieldInfo
    {
        public Guid Uid { get; set; }

        public string TableName { get; set; }
        
        public string DbName { get; set; }

        public string PsName { get; set; }

        public string DisplayName { get; set; }

        public string PropertyName { get; set; }

        public Type DataType { get; set; }

        public PsConversionType ConversionType { get; set; }

        public PsFieldType FieldType { get; set; }

        public PsOrigin Origin { get; set; }

        public bool IsUpdatable { get; set; }

        public PsFieldInfo()
        {
            IsUpdatable = true;
        }
    }
}
