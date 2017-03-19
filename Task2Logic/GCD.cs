using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Logic
{
    /// <summary>
    /// Class calculating the greatest common divisor of numbers
    /// </summary>
    public class GCD
    {
        #region Fields
        /// <summary>
        ///  Set static timer to remember the time
        /// </summary>
        private static readonly Stopwatch timer = new Stopwatch();
        #endregion

        #region Public Methods

        /// <summary>
        /// Determination of the GCD for two numbers by Euclid method 
        /// </summary>
        /// <param name="x">first number</param>
        /// <param name="y">second number</param>
        /// <param name="time">time in milliseconds</param>
        /// <param name="single">single time call or many </param>
        /// <returns>the greatest common divisor of two numbers</returns>
        public static int Euclid(out long time, int x, int y, bool single = true)
        {
            if(single)
                timer.Restart();
            else 
                timer.Start();
            while (y != 0)
                y = x % (x = y);
            time = timer.ElapsedMilliseconds;
            timer.Stop();

            return Math.Abs(x);
        }
        /// <summary>
        /// Determination of the GCD for unkown amount of numbers by Euclid method 
        /// </summary>
        /// <param name="n">array of values</param>
        /// <param name="time">time in milliseconds</param>
        /// <returns>the greatest common divisor of the numbers</returns>
        public static int Euclid(out long time, params int [] n)
        {
            if (n == null)
            {
                time = -1;
                throw new NullReferenceException();
            }

            if (n.Length == 0)
            {
                time = -1;
                return -1;
            }
            var gcd = n[0];
            for (var i = 0; i < n.Length - 1; i++)
            {
                gcd = Euclid(out time, gcd, n[i + 1], false);
            }
            time = timer.ElapsedMilliseconds;
            return gcd;
        }
        /// <summary>
        /// Determination of the GCD for two numbers by Stein method 
        /// </summary>
        /// <param name="x">first number</param>
        /// <param name="y">second number</param>
        /// <param name="time">time in milliseconds</param>
        /// <param name="single">single time call or many </param>
        /// <returns>the greatest common divisor of two numbers</returns>
        public static int BinaryGCD(out long time, int x, int y, bool single = true)
        {
            x = Math.Abs(x);
            y = Math.Abs(y);
            if (x == 0)
            {
                time = 0;
                return y;
            }
            if (y == 0)
            {
                time = 0;
                return x;
            }
            if (single)
                timer.Restart();
            else
                timer.Start();
            var shift = 0;
            for (shift = 0; ((x | y) & 1) == 0; ++shift)
            {
                x >>= 1;
                y >>= 1;
            }
            while ((x & 1) == 0)
                x >>= 1;
            do
            {
                while ((y & 1) == 0)
                    y >>= 1;
                if (x > y)
                {
                    int t = y;
                    y = x;
                    x = t;
                }
                y = y - x;
            } while (y != 0);
            time = timer.ElapsedMilliseconds;
            timer.Stop();
            return x << shift;
        }
        /// <summary>
        /// Determination of the GCD for unkown amount of numbers by Stein method 
        /// </summary>
        /// <param name="n">array of values</param>
        /// <param name="time">time in milliseconds</param>
        /// <returns>the greatest common divisor of the numbers</returns>
        public static int BinaryGCD(out long time, params int[] n)
        {
            if (n == null)
            {
                time = -1;
                throw new NullReferenceException();
            }

            if (n.Length == 0)
            {
                time = -1;
                return -1;
            }
            var gcd = n[0];
            for (var i = 0; i < n.Length - 1; i++)
            {
                gcd = BinaryGCD(out time, gcd, n[i + 1], false);
            }
            time = timer.ElapsedMilliseconds;
            return gcd;
        }
        #endregion
    }
}
