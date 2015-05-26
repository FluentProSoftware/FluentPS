namespace FluentPro.FluentPS.CodeGenerator.Operations.GenerateFromTemplate.Model
{
    using System.Collections.Generic;
    using FluentPS.Model;

    public class NativeFieldsSectionInfo
    {
        public string Name { get; set; }

        public List<PsFieldInfo> Fields { get; set; }

        public NativeFieldsSectionInfo()
        {
            Fields = new List<PsFieldInfo>();
        }
    }
}
