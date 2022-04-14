using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11
{
    public class FizzBuzz
    {
        public IEnumerable<string> FizzBuzzing()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    yield return "FizzBuzz";
                }
                else
                if (i % 3 == 0)
                {
                    yield return "Fizz";
                }
                else
                if (i % 5 == 0)
                {
                    yield return "Buzz";
                }
                else
                {
                    yield return i.ToString();
                }
            }
        }
    }
}
