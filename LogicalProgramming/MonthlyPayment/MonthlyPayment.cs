using System;

namespace LogicalProgramming.MonthlyPayment
{
    class MonthlyPayment
    {
        /// <summary>
        /// Calculate Monthly Payment
        /// </summary>
        /// <param name="PrincipleAmount"></param>
        /// <param name="NoOfYear"></param>
        /// <param name="Rate"></param>
        /// <returns></returns>
        public static double CalculateMontlyPayment(int PrincipleAmount, int NoOfYear, float Rate)
        {
            float r = Rate / (12 * 100);
            int n = 12 * NoOfYear;
            double payment = (PrincipleAmount * r) / (1 - Math.Pow((1 + r), -n));
            return payment;
        }
    }
}
