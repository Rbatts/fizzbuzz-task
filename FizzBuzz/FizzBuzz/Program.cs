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
            for (var i = 1; i <= 255; i = i + 1)
            {
                string values = "";
                if (i % 3 == 0)
                {
                    values = values + "Fizz";
                }
                if (i % 11 == 0)
                {
                    values = "Bong";
                }
                if (i % 13 == 0)
                {
                    values = values + "Fezz";
                }
                if (i % 5 == 0)
                {
                    values = values + "Buzz";
                }
                if (i % 7 == 0)
                {
                    values = values + "Bang";
                }
                if (i % 17 == 0)
                {
                    
                }
                if (values == "")
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(values);
                }
            }
            Console.ReadLine();

        }
    }
}
