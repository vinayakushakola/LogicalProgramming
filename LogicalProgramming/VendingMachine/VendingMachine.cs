using System;

namespace LogicalProgramming.VendingMachine
{
    class VendingMachine
    {
        private const int ONE_THOUSAND = 1000;
        private const int FIVE_HUNDRED = 500;
        private const int ONE_HUNDRED = 100;
        private const int FIFTY = 50;
        private const int TEN = 10;
        private const int FIVE = 5;
        private const int TWO = 2;
        private const int ONE = 1;

        public static int GetMinimumChange(int amount)
        {
            int minimumNotes = 0;
            while (amount != 0)
            {
                if (amount >= ONE_THOUSAND)
                {
                    amount -= ONE_THOUSAND;
                    minimumNotes++;
                }
                else if (amount >= FIVE_HUNDRED)
                {
                    amount -= FIVE_HUNDRED;
                    minimumNotes++;
                }
                else if (amount >= ONE_HUNDRED)
                {
                    amount -= ONE_HUNDRED;
                    minimumNotes++;
                }
                else if (amount >= FIFTY)
                {
                    amount -= FIFTY;
                    minimumNotes++;
                }
                else if (amount >= TEN)
                {
                    amount -= TEN;
                    minimumNotes++;
                }
                else if (amount >= FIVE)
                {
                    amount -= FIVE;
                    minimumNotes++;
                }
                else if (amount >= TWO)
                {
                    amount -= TWO;
                    minimumNotes++;
                }
                else if (amount >= ONE)
                {
                    amount -= ONE;
                    minimumNotes++;
                }
                else
                {
                    return 0;
                }
            }
            return minimumNotes;
        }
    }
}
