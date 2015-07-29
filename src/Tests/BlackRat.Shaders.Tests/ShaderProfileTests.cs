using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackRat.Shaders.Tests
{
    [TestClass]
    public class ShaderProfileTests
    {
        [TestMethod]
        public void ShaderProfile_ConstructorTest()
        {
            var sm = new ShaderModel(4, 1);
            var kind = ShaderKind.VertexShader;

            var profile = new ShaderProfile(sm, kind);

            Assert.AreEqual(sm, profile.ShaderModel);
            Assert.AreEqual(kind, profile.ShaderKind);
        }
    }
}
