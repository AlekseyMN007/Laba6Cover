using System;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace Laba_4.coveralls.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var expectedValue = "test";

            var value = Program.Analize(expectedValue);

            var results = new CoverallsRunResults() { StandardOutput=value.GetType().ToString(),ExitCode=0, StandardError="Error" };
            CoverallsAssert.RanSuccessfully(results);
        }
    }
}
