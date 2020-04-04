using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Laba_4.mstest.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expectedValue = "test";

            var value = Program.Analize(expectedValue);

            Assert.AreEqual(expectedValue.GetType().ToString(), value.GetType().ToString());
        }
    }
}
