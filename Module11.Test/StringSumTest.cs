using Xunit;
using System;

namespace Module11.Test
{
    public class StringSumTest
    {
        [Theory]
        [InlineData(null, "123")]
        [InlineData("123", null)]
        [InlineData(null, null)]
        public void Sum_Null_ThrowsException(string num1, string num2)
        {
            StringSum stringSum = new StringSum();

            Action action = () => stringSum.Sum(num1, num2);

            Assert.Throws<ArgumentNullException>(action);
        }

        [Theory]
        [InlineData("", "123")]
        [InlineData("123", "")]
        [InlineData("", "")]
        public void Sum_EmptyString_ThrowsException(string num1, string num2)
        {
            StringSum stringSum = new StringSum();

            Action action = () => stringSum.Sum(num1, num2);

            Assert.Throws<ArgumentException>(action);
        }
    }
}

