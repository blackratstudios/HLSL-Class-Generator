using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackRat.Shaders.Tests
{
    [TestClass]
    public class ShaderModelTests
    {
        private ShaderModel sm40 = new ShaderModel(4, 0);
        private ShaderModel sm41 = new ShaderModel(4, 1);
        private ShaderModel sm50 = new ShaderModel(5, 0);
        private ShaderModel sm51 = new ShaderModel(5, 1);

        public ShaderModelTests()
        {

        }

        [TestMethod]
        public void ShaderModel_ConstructorTest()
        {
            int major = 4;
            int minor = 3;

            var sm = new ShaderModel(major, minor);

            Assert.AreEqual(major, sm.MajorVersion);
            Assert.AreEqual(minor, sm.MinorVersion);
        }

        [TestMethod]
        public void ShaderModel_Constructor_InvalidArgsTest()
        {
            // Major version
            try { new ShaderModel(0, 0); }
            catch(ArgumentException ex)
            {
                Assert.IsTrue(ex.ParamName == "majorVersion");
            }

            try { new ShaderModel(-1, 0); }
            catch (ArgumentException ex)
            {
                Assert.IsTrue(ex.ParamName == "majorVersion");
            }

            // Minor version

            try { new ShaderModel(1, -1); }
            catch (ArgumentException ex)
            {
                Assert.IsTrue(ex.ParamName == "minorVersion");
            }
        }

        [TestMethod]
        public void ShaderModel_CompareToTest()
        {
            var dupeSm50 = new ShaderModel(5, 0);

            Assert.IsTrue(sm40.CompareTo(sm50) < 0);
            Assert.IsTrue(sm40.CompareTo(sm40) == 0);
            Assert.IsTrue(sm50.CompareTo(sm40) > 0);

            // op_LessThan
            Assert.IsTrue(sm40 < sm41);
            Assert.IsTrue(sm40 < sm50);
            Assert.IsFalse(sm41 < sm40);
            Assert.IsFalse(sm50 < sm40);
            Assert.IsFalse(sm50 < dupeSm50);

            // op_GreaterThan
            Assert.IsTrue(sm51 > sm50); // Major + Minor
            Assert.IsTrue(sm50 > sm40); // Major
            Assert.IsFalse(sm40 > sm50); 
            Assert.IsFalse(sm50 > sm51);
            Assert.IsFalse(sm50 > dupeSm50);

            Assert.IsTrue(sm40 <= sm41);
            Assert.IsTrue(sm40 <= sm50);
            Assert.IsFalse(sm41 <= sm40);
            Assert.IsFalse(sm50 <= sm40);

            Assert.IsFalse(sm40 >= sm41);
            Assert.IsFalse(sm40 >= sm50);
            Assert.IsTrue(sm41 >= sm40);
            Assert.IsTrue(sm50 >= sm40);

            Assert.IsTrue(sm50 <= dupeSm50);
            Assert.IsTrue(sm50 >= dupeSm50);
        }

        [TestMethod]
        public void ShaderModel_GetHashCodeTest()
        {
            int major = 4;
            int minor = 9;

            var sm = new ShaderModel(major, minor);

            int expectedHash = major ^ minor;

            Assert.AreEqual(expectedHash, sm.GetHashCode());
        }

        [TestMethod]
        public void ShaderModel_IEquatableTest()
        {
            // Equals(ShaderModel)
            {
                var dupeSm50 = new ShaderModel(5, 0);

                Assert.IsTrue(dupeSm50.Equals(sm50));
                Assert.IsTrue(dupeSm50 == sm50);

                // Inequality
                Assert.IsFalse(dupeSm50.Equals(sm51));
                Assert.IsFalse(sm50 == sm41);
                Assert.IsTrue(sm50 != sm41);
            }

            // Equals(object)
            {
                var dupeSm50 = new ShaderModel(5, 0);

                Assert.IsTrue(dupeSm50.Equals((object)sm50));

                // Inequality
                Assert.IsFalse(dupeSm50.Equals((object)sm51));
                Assert.IsFalse(sm50.Equals(null));
            }
        }

        [TestMethod]
        public void ShaderModel_ToStringTest()
        {
            int major = 5;
            int minor = 9;

            string expected = $"{major}_{minor}";

            var sm = new ShaderModel(major, minor);

            Assert.AreEqual(expected, sm.ToString());
        }
    }
}
