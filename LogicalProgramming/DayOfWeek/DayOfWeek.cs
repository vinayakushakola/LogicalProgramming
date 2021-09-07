using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming.DayOfWeek
{
    class DayOfWeek
    {
        /// <summary>
        /// Logic for date (Sun, Mon,...Sat)
        /// </summary>
        /// <param name="day">Day</param>
        /// <param name="month">Month</param>
        /// <param name="year">Year</param>
        /// <returns>Return day in integer form</returns>
        public static int GetDayOfWeek(int day, int month, int year)
        {
            int y0, x, m0, d0;
            y0 = year - (14 - month) / 12;
            x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            m0 = month + 12 * ((14 - month) / 12) - 2;
            d0 = (day + x + (31 * m0) / 12) % 7;
            return d0;
        }
    }
}
