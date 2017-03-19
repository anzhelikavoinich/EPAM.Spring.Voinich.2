using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Logic
{
    /// <summary>
    /// Class calculating radical of the nth degree
    /// </summary>
    public class Newton
    {
        #region Public Methods

        /// <summary>
        /// Determination of radical of the nth degree using the formula of Newton
        /// </summary>
        /// <param name="x">number</param>
        /// <param name="n">degree of radical</param>
        /// <param name="eps">error</param>
        /// <returns>radical of the nth degree</returns>
        
        public static double Calculate(double x, int n, double eps)
        {
            if (x < 0)
                return -1;
            var x1 = x;
            var x2 = 1.0 / n * ((n - 1) * x1 + x / Math.Pow(x1, n - 1));
            while (Math.Abs(x1 - x2) > eps)
            {
                x1 = x2;
                x2 = 1.0 / n * ((n - 1) * x1 + x / Math.Pow(x1, n - 1));
            }
            return x2;
        }
        #endregion

        
    }
}
