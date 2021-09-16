using System;

namespace LogicalProgramming
{
    class clsInputTaking
    {
        /// <summary>
        /// Vending Machine input taking logic
        /// </summary>
        internal static void CallVendingMachine()
        {
            int amount;
            bool IsAmountValid;
            Console.Write("\tEnter an amount to get change = ");
            IsAmountValid = int.TryParse(Console.ReadLine(), out amount);
            Console.WriteLine("\tOutput:");
            if (IsAmountValid)
            {
                int totalNotes = 0;
                if (VendingMachine.VendingMachine.GetMinimumChange(amount))
                {
                    Console.WriteLine("\tAmount = {0}", amount);
                    for (int i = 0; i <= 9; i++)
                    {
                        if (VendingMachine.VendingMachine.noteCounter[i] != 0)
                        {
                            Console.WriteLine("\t" + VendingMachine.VendingMachine.notes[i] + " Notes = " +
                                VendingMachine.VendingMachine.noteCounter[i]);
                            totalNotes += VendingMachine.VendingMachine.noteCounter[i];
                        }
                    }
                    Console.WriteLine("\tTotal Notes = {0}", totalNotes);
                }
            }
            else
            {
                Console.WriteLine("\tInvalid amount entered");
            }
        }

        /// <summary>
        /// Day of week input taking logic
        /// </summary>
        internal static void CallDayOfWeek()
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
        internal static void CallTemperatureConvertor()
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
        internal static void CallMonthlyPayment()
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
        internal static void CallSquareRoot()
        {
            int numSq;
            Console.Write("\tEnter number = ");
            bool IsValidNo = int.TryParse(Console.ReadLine(), out numSq);
            Console.WriteLine("\tOutput: ");
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
