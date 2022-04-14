using System;
using Xunit;

namespace Module11.Test
{
    public class LeapYearTest
    {

        [Theory]
        [InlineData(0, true)]
        [InlineData(-2016, false)]
        [InlineData(-2001, true)]
        public void IsLeapYear_InvalidYear_ThrowsException(int year, bool expected)
        {
            var leapYear = new LeapYear();

            Action action = () => leapYear.IsLeapYear(year);

            Assert.Throws<ArgumentOutOfRangeException>(action);
        }

        [Theory]
        [InlineData(2016, true)]
        [InlineData(2015, false)]
        [InlineData(2000, true)]
        [InlineData(1900, false)]
        [InlineData(1, false)]
        public void IsLeapYear_Year_ReturnsBool(int year, bool expected)
        {
            var leapYear = new LeapYear();

            var result = leapYear.IsLeapYear(year);

            Assert.Equal(expected, result);
        }
    }
}
