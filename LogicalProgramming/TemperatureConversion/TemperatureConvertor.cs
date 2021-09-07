using System;

namespace LogicalProgramming.TemperatureConversion
{
    class TemperatureConvertor
    {
        /// <summary>
        /// Celsius To Fahrenheit (°C × 9/5) + 32 = °F
        /// </summary>
        /// <param name="temp"></param>
        public static int CelsiusToFahrenheit(int temp)
        {
            int tempInFr = temp * (9 / 5) + 32;
            return tempInFr;
        }

        /// <summary>
        /// Fahrenheit To Celsius (°F − 32) x 5/9 = °C
        /// </summary>
        /// <param name="temp"></param>
        public static int FahrenheitToCelsius(int temp)
        {
            int tempInCe = (temp - 32) * (5 / 9);
            return tempInCe;
        }
    }
}
