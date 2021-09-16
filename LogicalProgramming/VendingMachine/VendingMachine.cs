using System;

namespace LogicalProgramming.VendingMachine
{
    class VendingMachine
    {
        public static int[] notes = new int[] { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        public static int[] noteCounter = new int[10];

        /// <summary>
        /// Logic for Minimum Notes Change
        /// </summary>
        /// <param name="amount"> Amount </param>
        /// <returns> No of Notes </returns>
        public static bool GetMinimumChange(int amount)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (amount >= notes[i])
                {
                    noteCounter[i] = amount / notes[i];
                    amount = amount - noteCounter[i] * notes[i];
                }
            }
            if (amount == 0)
                return true;
            else
                return false;
        }
    }
}
