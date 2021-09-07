using System;

namespace LogicalProgramming.SquareRoot
{
    class SquareRoot
    {
        /// <summary>
        /// Finding square root of a number
        /// </summary>
        /// <param name="numSq"></param>
        /// <returns></returns>
        public static double GetSquareRoot(double numSq)
        {
            double c = numSq;
            double t = c;
            const double Epsilon = 1E-15;
            double squareRoot;
            while (true)
            {
                squareRoot = 0.5 * (t + (c / t));
                if (Math.Abs(squareRoot - t) < Epsilon)
                    break;
                t = squareRoot;
            }
            return squareRoot;
        }
    }
}
