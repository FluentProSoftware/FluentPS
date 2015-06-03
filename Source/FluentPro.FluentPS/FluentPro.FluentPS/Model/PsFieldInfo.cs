namespace FluentPro.FluentPS.Model
{
    using System;

    public class PsFieldInfo
    {
        public Guid Uid { get; set; }

        public string TableName { get; set; }

        public string DisplayName { get; set; }
        
        public string DbName { get; set; }

        public string PsName { get; set; }

        public PsDataType PsDataType { get; set; }

        public Type DataType { get; set; }

        public bool IsUpdatable { get; set; }

        public PsFieldInfo()
        {
            IsUpdatable = true;
        }
    }
}
