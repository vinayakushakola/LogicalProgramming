using System;
using System.Threading;

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
                    Console.WriteLine("\t3. Temperature Convertor");
                    Console.WriteLine("\t4. Monthly Payment");
                    Console.WriteLine("\t5. Square Root");
                    Console.WriteLine("\t6. Exit");
                    Console.Write("Enter choice = ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\n\t========== 1. Vending Machine ==========");
                            clsInputTaking.CallVendingMachine();
                            break;
                        case 2:
                            Console.WriteLine("\n\t========== 2. Day Of Week ==========");
                            clsInputTaking.CallDayOfWeek();
                            break;
                        case 3:
                            Console.WriteLine("\n\t========== 3. Temperature Conversion ==========");
                            clsInputTaking.CallTemperatureConvertor();
                            break;
                        case 4:
                            Console.WriteLine("\n\t========== 4. Monthly Payment ==========");
                            clsInputTaking.CallMonthlyPayment();
                            break;
                        case 5:
                            Console.WriteLine("\n\t========== 4. Square Root ==========");
                            clsInputTaking.CallSquareRoot();
                            break;
                        case 6:
                            Console.WriteLine("\nThank You for visiting");
                            flag = false;
                            break;
                        default:
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
                Thread.Sleep(2000);
            }
            Console.ReadKey();
        }
    }
}
