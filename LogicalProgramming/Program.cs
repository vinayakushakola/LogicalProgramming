using System;

namespace LogicalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============== Welcome to Logical Programming ===============");
            Console.WriteLine();
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Choose any one option");
                    Console.WriteLine("\t1. Vending Machine");
                    Console.WriteLine("\t2. Day Of Week");
                    Console.WriteLine("\t3. Exit");
                    Console.Write("Enter choice = ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\n\t========== 1. Vending Machine ==========\n");
                            CallVendingMachine();
                            break;
                        case 2:
                            Console.WriteLine("\n\t========== 2. Day Of Week ==========");
                            CallDayOfWeek();
                            break;
                        case 3:
                            Console.WriteLine("\nThank You for visiting");
                            flag = false;
                            break;
                        case 4:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("\nInvalid Input");
                    Console.WriteLine("Try Again!");
                }
                Console.WriteLine("\n==============================================================\n");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Vending Machine input taking logic
        /// </summary>
        private static void CallVendingMachine()
        {
            int amount;
            bool IsAmountValid;
            Console.Write("\tEnter an amount to get change = ");
            IsAmountValid = int.TryParse(Console.ReadLine(), out amount);
            Console.WriteLine("\tOutput:");
            if (IsAmountValid)
            {
                Console.WriteLine("\tAmount = {0} \n\tNotes = {1}", amount, VendingMachine.VendingMachine.GetMinimumChange(amount));
            }
            else
            {
                Console.WriteLine("\tInvalid amount entered");
            }
        }

        /// <summary>
        /// Day of week input taking logic
        /// </summary>
        private static void CallDayOfWeek()
        {
            try
            {
                int day, month, year;
                Console.Write("\tEnter Day = ");
                day = Convert.ToInt32(Console.ReadLine());
                Console.Write("\tEnter Month = ");
                month = Convert.ToInt32(Console.ReadLine());
                Console.Write("\tEnter Year = ");
                year = Convert.ToInt32(Console.ReadLine());
                Day d0 = (Day)DayOfWeek.DayOfWeek.GetDayOfWeek(day, month, year);
                Console.WriteLine("\tOutput:");
                Console.WriteLine("\tDay = {0}", d0);
            }
            catch
            {
                Console.WriteLine("\tInvalid date entered");
            }
        }

        /// <summary>
        /// Enum for Days
        /// </summary>
        private enum Day
        {
            Sunday = 0,
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6
        }
    }
}
