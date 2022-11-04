using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public void Check(int num)
        {
            int reverse = 0;
            while (num != 0)
            {
                int reminder = num % 10;
                reverse = reverse * 10 + reminder;
                num /= 10;
            }
            Console.WriteLine(reverse);
        }
    }
}
