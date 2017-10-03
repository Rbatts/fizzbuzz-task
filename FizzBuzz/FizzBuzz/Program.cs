using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 100; i = i + 1)
            {
                if  (i % 11 == 0)
                {
                    Console.WriteLine("Bong");
                }
                else if (i % 21 == 0)
                {
                    Console.WriteLine("FizzBang");
                }
                else if (i % 7 == 0) 
                {
                    Console.WriteLine("Bang");
                }
                else if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

        }
    }
}
