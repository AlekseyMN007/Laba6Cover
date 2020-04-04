using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Laba_4.coveralls.Test
{
    class CoverallsAssert
    {
        public static void RanSuccessfully(CoverallsRunResults results)
        {
            Assert.True(results.ExitCode == 0, $"Expected a Successful run but returned an exit code of {results.ExitCode}:\n{results.StandardError}");
        }
    }
}
