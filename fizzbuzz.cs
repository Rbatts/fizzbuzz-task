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
                List<string> valueList = new List<string>();
                if (i % 3 == 0)
                {
                    valueList.Add("Fizz");
                }
                if (i % 13 == 0)
                {
                    valueList.Add("Fezz");
                }
                if (i % 5 == 0)
                {
                    valueList.Add("Buzz");
                }
                if (i % 7 == 0)
                {
                    valueList.Add("Bang");
                }
                if (i % 11 == 0)
                {
                    valueList.Clear();
                    valueList.Add("Bong");
                }
                if ((i % 11 ==0) && (i % 13 == 0))
                {
                    valueList.Add("Fezz");
                    valueList.Reverse();
                }
                if (i % 17 == 0)
                {
                    valueList.Reverse();
                }
                if (!valueList.Any())
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(string.Join("", valueList));
                }
            }
            Console.ReadLine();

        }

    }

}