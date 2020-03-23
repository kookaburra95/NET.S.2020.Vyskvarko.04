using System;
using System.Diagnostics;


namespace GCD
{
    /// <summary>
    /// A class containing methods for finding GCD.
    /// </summary>
    public static class FindGCD
    {
        /// <summary>
        /// Euclidean method for two numbers.
        /// </summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second number.</param>
        /// <returns>GCD.</returns>
        public static int EuclideanGCD(int a, int b)
        {
            try
            {
                checked
                {
                    a = Math.Abs(a);
                    b = Math.Abs(b);
                }
            }
            catch
            {
                throw new OverflowException("Number is biggest Int.");
            }

            if (b == 0)
            {
                return a;
            }
            return EuclideanGCD(b, a % b);
        }

        /// <summary>
        /// Euclidean method for two or more numbers.
        /// </summary>
        /// <param name="time">The time spent by GCD.</param>
        /// <param name="numbers">Array of numbers.</param>
        /// <returns>GCD.</returns>
        public static int FindEuclideanGCD(out long time, params int[] numbers)
        {
            if (numbers.Length < 2)
            {
                throw new ArgumentException("Values ​​less than two.");
            }

            Stopwatch stopwatch = Stopwatch.StartNew();

            var result = numbers[0];

            for (var i = 1; i < numbers.Length; i++)
            {
                result = EuclideanGCD(numbers[i], result);

                if (result == 1)
                {
                    stopwatch.Stop();
                    time = stopwatch.ElapsedTicks;

                    return 1;
                }
            }

            stopwatch.Stop();
            time = stopwatch.ElapsedTicks;

            return result;
        }

        /// <summary>
        /// Binary method for two numbers.
        /// </summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second number.</param>
        /// <returns>GCD.</returns>
        public static int BinaryGCD(int a, int b)
        {
            try
            {
                checked
                {
                    a = Math.Abs(a);
                    b = Math.Abs(b);
                }
            }
            catch
            {
                throw new OverflowException("Number is biggest Int.");
            }

            if (a == b)
            {
                return b;
            }

            if (a == 0)
            {
                return b;
            }

            if (b == 0)
            {
                return a;
            }

            if ((~a & 1) == 1)
            {
                if ((b & 1) == 1)
                {
                    return BinaryGCD(a >> 1, b);
                }
                return BinaryGCD(a >> 1, b >> 1) << 1;

            }

            if ((~b & 1) == 1)
            {
                return BinaryGCD(a, b >> 1);
            }

            if (a > b)
            {
                return BinaryGCD((a - b) >> 1, b);
            }

            return BinaryGCD((b - a) >> 1, a);
        }

        /// <summary>
        /// Binary method for two or more numbers.
        /// </summary>
        /// <param name="time">The time spent by GCD.</param>
        /// <param name="numbers">Array of numbers.</param>
        /// <returns>GCD.</returns>
        public static int FindBinaryGCD(out long time, params int[] numbers)
        {
            if (numbers.Length < 2)
            {
                throw new ArgumentException("Values ​​less than two.");
            }

            Stopwatch stopwatch = Stopwatch.StartNew();

            var result = numbers[0];

            for (var i = 1; i < numbers.Length; i++)
            {
                result = BinaryGCD(numbers[i], result);

                if (result == 1)
                {
                    stopwatch.Stop();
                    time = stopwatch.ElapsedTicks;

                    return 1;
                }
            }

            stopwatch.Stop();
            time = stopwatch.ElapsedTicks;

            return result;
        }
    }   
}
