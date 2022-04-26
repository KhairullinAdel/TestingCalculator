using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your counting string");
                try
                {
                    Console.WriteLine(Calculator.Calculate(Console.ReadLine()));
                }
                catch (Exception)
                {
                    Console.WriteLine("Input data is incorrect \nPlease, try again\n");
                }
            }
        }
    }
}
