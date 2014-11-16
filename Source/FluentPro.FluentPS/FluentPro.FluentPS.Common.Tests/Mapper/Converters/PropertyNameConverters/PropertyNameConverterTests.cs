using FluentPro.FluentPS.Common.Mapper.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentPro.FluentPS.Common.Tests.Mapper.Converters.PropertyNameConverters
{
    public abstract class PropertyNameConverterTests
    {
        public abstract IPropertyNameConverter GetSut();

        public void Validate(string input, string output)
        {
            var sut = GetSut();

            var res = sut.GetName(input);

            Assert.IsTrue(res == output);
        }
    }
}
