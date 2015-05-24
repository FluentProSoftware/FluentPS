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
           
        };
    }

      //private DataColumn columnCONV_STRING;
      //private DataColumn columnMD_PROP_NAME;
    public class FieldInfo
    {
        public Guid Uid { get; set; }
        
        public string Name { get; set; }

        public string DisplayName { get; set; }

        public PsEntityType EntityType { get; set; }

        public PsFieldConversionType ConversionType { get; set; }

        public bool IsCustom { get; set; }

        public Guid LookupTableGuid { get; set; }

        public bool IsMultiValue { get; set; }

        public bool IsMultiLine { get; set; }

        //public FieldInfo(PsDataType psEntiType, Guid fieldUid, string name, PsFieldConversionType psConversionType, Type type)
            //{

            //}
        }
}
