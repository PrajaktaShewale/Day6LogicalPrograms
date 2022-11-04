
using System;
using System.Diagnostics;

namespace LogicalPrograms

{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Logical Programming Problems");
                Console.WriteLine("1. Fibonaccis Series" + "\n" + "2. Check Perfect Number" + "\n" + "3. PrimeNumber" + "\n" + "4. Reverse enter" + "\n" + "5. Coupon Number" + "\n" + "6. Stop Watch" + "\n" + "7. Exit");

                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        FibonacciSeries Fibonacci = new FibonacciSeries();
                        Fibonacci.Print(4);
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}