using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class MonthlyPayment

    {
        public static void MonthPay()
        {            
            Console.WriteLine("Principal Loan Amount : ");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Percent intrest compounded monthly : ");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Number of years to pay off : ");
            double Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(P);
            double n=12*Y;
            double r = R / 12 * 100;
            double payment = (P * r) / (1 - Math.Pow((1 + r), (-n)));
            Console.WriteLine("Total Payment Amount is  " + payment);
        }
    }
}
