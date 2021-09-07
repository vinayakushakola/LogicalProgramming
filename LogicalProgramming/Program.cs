using System;

namespace LogicalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============== Welcome to Logical Programming ===============");
            Console.WriteLine();

            Console.WriteLine("\t========== Vending Machine ==========\n");
            CallVendingMachine();
            Console.ReadKey();
        }

        private static void CallVendingMachine()
        {
            int amount;
            Console.Write("\tEnter an amount to get change = ");
            amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\tAmount = {0} \n\tNotes = {1}",amount, VendingMachine.VendingMachine.GetMinimumChange(amount));
        }
    }
}
