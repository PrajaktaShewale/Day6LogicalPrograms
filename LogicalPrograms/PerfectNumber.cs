using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public void perf(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    sum++;
                }
            }
            if (sum == 2)
                Console.WriteLine(num + " It is an Perfect Num");
            else
                Console.WriteLine(num + " It is not an Perfect Num");

        }
    }
}
