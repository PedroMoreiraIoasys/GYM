using System;
using Xunit;

namespace GYM_GetYourMuscles.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test1(bool boolean)
        {
            Assert.True(boolean);
        }
    }
}
