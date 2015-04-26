﻿using FluentPro.FluentPS.Common.Mapper.Interfaces;
using System;

namespace FluentPro.FluentPS.Common.Mapper.Converters.PropertyNameConverters
{
    public class RemoveWhiteSpacesPropertyNameConverter : IPropertyNameConverter
    {
        public string GetDestName(string sourceName)
        {
            return sourceName.Replace(" ", "");
        }

        public string GetSourceName(string destName)
        {
            throw new NotSupportedException();

        }
    }
}
