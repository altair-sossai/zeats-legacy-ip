using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zeats.Legacy.IP.UnitTest
{
    [TestClass]
    public class IpValidatorTest
    {
        [TestMethod]
        public void IsIpV4()
        {
            Assert.IsFalse(IpValidator.IsIpV4(null));
            Assert.IsFalse(IpValidator.IsIpV4(string.Empty));

            Assert.IsFalse(IpValidator.IsIpV4("Lorem"));
            Assert.IsFalse(IpValidator.IsIpV4("10"));
            Assert.IsFalse(IpValidator.IsIpV4("10.20"));
            Assert.IsFalse(IpValidator.IsIpV4("10.20.30"));
            Assert.IsFalse(IpValidator.IsIpV4("10.20.30.256"));
            Assert.IsFalse(IpValidator.IsIpV4("10.a.30.40"));

            for (var i = 0; i < 256; i += 7)
            for (var j = 0; j < 256; j += 7)
            for (var k = 0; k < 256; k += 7)
            for (var l = 0; l < 256; l += 7)
                Assert.IsTrue(IpValidator.IsIpV4($"{i}.{j}.{k}.{l}"));
        }
    }
}