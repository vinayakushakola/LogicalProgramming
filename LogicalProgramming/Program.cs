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
                            CallVendingMachine();
                            break;
                        case 2:
                            Console.WriteLine("\n\t========== 2. Day Of Week ==========");
                            CallDayOfWeek();
                            break;
                        case 3:
                            Console.WriteLine("\n\t========== 3. Temperature Conversion ==========");
                            CallTemperatureConvertor();
                            break;
                        case 4:
                            Console.WriteLine("\n\t========== 4. Monthly Payment ==========");
                            CallMonthlyPayment();
                            break;
                        case 5:
                            Console.WriteLine("\n\t========== 4. Square Root ==========");
                            CallSquareRoot();
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
        /// Temperature Conversion input taking logic
        /// </summary>
        private static void CallTemperatureConvertor()
        {
            Console.Write("\tEnter temprature = ");
            int temperature;
            bool IsValidNo = int.TryParse(Console.ReadLine(), out temperature);
            if (IsValidNo)
            {
                Console.WriteLine("\tChoose Conversion");
                Console.WriteLine("\t\t1. Celsius to Fahrenheit");
                Console.WriteLine("\t\t2. Fahrenheit to Celsius");
                Console.Write("\tEnter choice = ");
                int choice = 0;
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("\tOutput:");
                switch (choice)
                {
                    case 1:
                        int tempInFr = TemperatureConversion.TemperatureConvertor.CelsiusToFahrenheit(temperature);
                        Console.WriteLine("\tCelsius {0} to Fahrenheit {1}", temperature, tempInFr);
                        break;
                    case 2:
                        int tempInCe = TemperatureConversion.TemperatureConvertor.FahrenheitToCelsius(temperature);
                        Console.WriteLine("\tFahrenheit {0} to Celcius {1}", temperature, tempInCe);
                        break;
                    default:
                        Console.WriteLine("\tInvalid choice");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\tInvalid number entered");
            }
        }

        /// <summary>
        /// Monthly payment input taking logic
        /// </summary>
        private static void CallMonthlyPayment()
        {
            try
            {
                Console.Write("\tEnter principle amount = ");
                int Principleamount = int.Parse(Console.ReadLine());
                Console.Write("\tEnter No of year = ");
                int NoOfYear = int.Parse(Console.ReadLine());
                Console.Write("\tEnter Rate = ");
                int Rate = int.Parse(Console.ReadLine());
                double payment = MonthlyPayment.MonthlyPayment.CalculateMontlyPayment(Principleamount, NoOfYear, Rate);
                Console.WriteLine("\tMonthly Payment = {0}", payment);
            }
            catch
            {
                Console.Write("Invalid value");
            }
        }

        /// <summary>
        /// Square Root input taking logic
        /// </summary>
        private static void CallSquareRoot()
        {
            int numSq;
            Console.Write("\tEnter number = ");
            bool IsValidNo = int.TryParse(Console.ReadLine(), out numSq);
            Console.WriteLine("Output: ");
            if (IsValidNo)
            {
                double squareRoot = SquareRoot.SquareRoot.GetSquareRoot(numSq);
                Console.WriteLine("\tSquare Root = {0}", squareRoot);
            }
            else
            {
                Console.WriteLine("\tInvalid number entered");
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
