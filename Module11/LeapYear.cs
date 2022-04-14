using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11
{
    public class LeapYear
    {
        public bool IsLeapYear(int year)
        {
            if (year <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (year % 4 != 0 || (year % 100 == 0 && year % 400 != 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
