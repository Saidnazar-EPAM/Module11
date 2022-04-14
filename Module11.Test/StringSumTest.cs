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
        [InlineData("  ", "123")]
        [InlineData("123", "")]
        [InlineData("", "")]
        [InlineData("888", "  ")]
        public void Sum_EmptyString_ThrowsException(string num1, string num2)
        {
            StringSum stringSum = new StringSum();

            Action action = () => stringSum.Sum(num1, num2);

            Assert.Throws<ArgumentException>(action);
        }

        [Theory]
        [InlineData("123", "123.5", "123")]
        [InlineData("-9685", "256", "256")]
        [InlineData("9863.5", "-123.8", "0")]
        [InlineData("0", "-236", "0")]
        [InlineData("0", "0", "0")]
        public void Sum_NotNaturalNumbers_SumOfNumbers(string num1, string num2, string sum)
        {
            StringSum stringSum = new StringSum();

            var result = stringSum.Sum(num1, num2);

            Assert.Equal(result, sum);
        }

        [Theory]
        [InlineData("123", "123", "246")]
        [InlineData("123456789", "987654321", "1111111110")]
        [InlineData("123456789101112131415", "151413121110987654321", "274869910212099785736")]
        [InlineData("9999", "1", "10000")]
        [InlineData("9999", "1111", "11110")]
        public void Sum_NaturalNumbers_SumOfNumbers(string num1, string num2, string sum)
        {
            StringSum stringSum = new StringSum();

            var result = stringSum.Sum(num1, num2);

            Assert.Equal(result, sum);
        }
    }
}

