using FluentPro.FluentPS.Common.Mapper.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentPro.FluentPS.Common.Tests.Mapper.Converters.PropertyNameConverters
{
    public abstract class PropertyNameConverterTests
    {
        public abstract IPropertyNameConverter GetSut();

        public void Validate(string source, string dest)
        {
            var sut = GetSut();

            var generatedDest = sut.GetName(source);

            Assert.IsTrue(generatedDest == dest);
        }
    }
}
