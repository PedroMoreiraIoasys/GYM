using System;
using Xunit;

namespace GYM_GetYourMuscles.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(true)]
        public void Test1(bool boolean)
        {
            Assert.True(boolean);
        }

        [Theory]
        [InlineData(true)]
        public void Test2(bool boolean)
        {
            Assert.True(boolean);
        }
    }
}
