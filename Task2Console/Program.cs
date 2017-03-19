using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2Logic;

namespace Task2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            long time;
            Console.WriteLine(GCD.Euclid(out time,-5,0) + "    time = " + time + " ms");
            Console.WriteLine(GCD.Euclid(out time, 78, 294, 570, 36) + "    time = " + time + " ms");

            Console.WriteLine(GCD.BinaryGCD(out time, -5, 0) + "    time = " + time + " ms");
            Console.WriteLine(GCD.BinaryGCD(out time, 78, 294, 570, 36) + "    time = " + time + " ms");
            Console.ReadKey();
        }
    }
}
