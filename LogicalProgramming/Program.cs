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
                    Console.WriteLine("\t2. Exit");
                    Console.Write("Enter choice = ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\n\t========== 1. Vending Machine ==========\n");
                            CallVendingMachine();
                            break;
                        case 2:
                            Console.WriteLine("\nThank You for visiting");
                            flag = false;
                            break;
                        case 3:
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
    }
}
