using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class TemperatureConversion
    {
        public float CelsiusConvert(float number)
        {
            float fahrenheit;
            fahrenheit = (number * 9/5) + 32;
            return fahrenheit;
        }
        public float FahrenheitConvert(float number)
        {
            float celsius;
            celsius = (number - 32) * 5/9;
            return celsius;
        }
    }
}
