
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
                Console.WriteLine("1. Fibonaccis Series" + "\n" + "2. Check Perfect Number" + "\n" + "3. PrimeNumber" + "\n" + "4. Reverse enter" + "\n" + "5. Coupon Number" + "\n" + "6. Stop Watch" + "\n" +
                    "7. Vending Machine" + "\n" + "8. DayOfWeek" + "\n" + "9. Temprature Conversion" + "\n" + "10. Monthly Payment" + "\n" + "11. Exit");

                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        FibonacciSeries Fibonacci = new FibonacciSeries();
                        Fibonacci.Print(4);
                        break;
                   case 2:
                        PerfectNumber perfect = new PerfectNumber();  
                        perfect.perf(10);
                        break;
                    case 3:
                        PrimeNumber prime = new PrimeNumber();
                        prime.Check(28);
                        break;
                    case 4:
                        ReverseNumber reverse = new ReverseNumber();
                        reverse.Check(458);
                        break;
                    case 5:
                        CouponNumber.GenerateCoupons(15);
                        break;
                    case 6:
                        StopWatch watch = new StopWatch();
                        watch.Start();
                        break;
                    case 7:
                        VendingMachine Ven = new VendingMachine();
                        Ven.Notes(2125);
                        break;
                    case 8:
                        DayOfWeek.DayOf();
                        break;
                    case 9:
                        TemperatureConversion conversion = new TemperatureConversion();
                        Console.WriteLine("1. CelciusToFarhnite \n 2. FarnhiteToCelcius ");
                        int input = Convert.ToInt32(Console.ReadLine());
                        if (input == 1)
                        {
                            float f = conversion.CelsiusConvert(100);
                            Console.WriteLine("Celcius To Farnhite is " + f);
                        }
                        else
                        {
                            float c = conversion.FahrenheitConvert(60);
                            Console.WriteLine("Franhite to Celcius is : " + c);
                        }

                        break;
                    case 10:
                        MonthlyPayment.MonthPay();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}