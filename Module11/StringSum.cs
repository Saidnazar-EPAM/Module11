using System.Text;
using System.Text.RegularExpressions;

namespace Module11
{
    public class StringSum
    {
        public string Sum(string num1, string num2)
        {
            if (num1 == null || num2 == null)
            {
                throw new ArgumentNullException();
            }
            if (string.IsNullOrWhiteSpace(num1) || string.IsNullOrWhiteSpace(num2))
            {
                throw new ArgumentException("One of the arguments is empty.");
            }

			num1 = num1.Trim();
			num2 = num2.Trim();

			var onlyDigit = new Regex(@"^\s*\d+\s*$");
			
			if (!onlyDigit.IsMatch(num1))
            {
				num1 = "0";
            }

			if (!onlyDigit.IsMatch(num2))
			{
				num2 = "0";
			}

			var sum = new StringBuilder();

			int carry = 0;

			if (num1.Length != num2.Length)
			{
				var maxLength = Math.Max(num1.Length, num2.Length);
				num1 = num1.PadLeft(maxLength, '0');
				num2 = num2.PadLeft(maxLength, '0');
			}

			for (int i = num1.Length - 1; i >= 0; i--)
			{
				var digitSum = (num1[i] - '0') + (num2[i] - '0') + carry;

				if (digitSum > 9)
				{
					carry = 1;
					digitSum -= 10;
				}
				else
				{
					carry = 0;
				}

				sum.Insert(0, digitSum);
			}

			if (carry == 1)
				sum.Insert(0, carry);

			return sum.ToString();
        }
    }
}