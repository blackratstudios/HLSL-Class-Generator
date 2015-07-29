using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackRat.Shaders.Tests
{
    [TestClass]
    public class ShaderKindTests
    {
        [TestMethod]
        public void ShaderKind_ToShortKindStringTest()
        {
            var values = Enum.GetValues(typeof(ShaderKind));

            foreach (var value in values)
            {
                var kind = (ShaderKind)(int)value;

                try
                {
                    var shortName = kind.ToShortKindString();

                    Assert.IsFalse(string.IsNullOrWhiteSpace(shortName), "ToShortKindString returned a null or empty string");
                }
                catch(InvalidOperationException)
                {
                    Assert.Fail("ToShortKindString did not return a string for all possible ShaderKind values");
                }
            }
        }
    }
}
