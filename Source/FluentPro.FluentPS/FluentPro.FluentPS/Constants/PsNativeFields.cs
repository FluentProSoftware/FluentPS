using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentPro.FluentPS.Constants
{
    public static class PsNativeFields
    {
        public static List<FieldInfo> FieldInfos = new List<FieldInfo>
        {
            new FieldInfo { EntityType = PsEntityType.Project, DataType = PsDataType.STRING}
        };
    }

    public class FieldInfo
    {
        public string Name { get; private set; }

        public PsEntityType EntityType { get; private set; }

        public PsDataType DataType { get; private set; }

        public FieldInfo(PsDataType psEntiType, string name, PsDataType psDataType, Type type)
        {
            
        }
    }
}
