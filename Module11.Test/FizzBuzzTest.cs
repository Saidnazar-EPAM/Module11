using System;
using Xunit;

namespace Module11.Test
{
    public class FizzBuzzTest
    {
        [Fact]
        public void FizzBuzzing_ReturnsEnumerable()
        {
            var fizzBuzz = new FizzBuzz();
            var i = 0;
            foreach (var item in fizzBuzz.FizzBuzzing())
            {
                i++;
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Assert.Equal("FizzBuzz", item);
                    continue;
                }
                if (i % 3 == 0)
                {
                    Assert.Equal("Fizz", item);
                    continue;
                }
                if (i % 5 == 0)
                {
                    Assert.Equal("Buzz", item);
                    continue;
                }
                Assert.Equal(i.ToString(), item);
            }
        }

    }
}
