using System;
using Xunit;

namespace Laba_4.xUnit.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var expectedValue = "test";

            var value= Program.Analize(expectedValue);

            Assert.Equal(expectedValue.GetType().ToString(), value.GetType().ToString());
;        }
    }
}
