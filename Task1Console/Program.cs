using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1Logic;

namespace Task1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate by Newton");
            Console.WriteLine(Newton.Calculate(2,10,0.000000001));
            Console.WriteLine("Calculate by Math.Pow");
            Console.WriteLine(Math.Pow(2,1/10.0));
            Console.ReadKey();
        }
    }
}
