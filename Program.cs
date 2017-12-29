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
            Console.Write("\n What do you want the maximum number to be? ");
            string input = Console.ReadLine();
            int MaxNum = Convert.ToInt32(input);

            Console.Write("\n Do you want to implement Fizz, y or n? ");
            string Response = Console.ReadLine();
            Console.Write("\n Do you want to implement Fezz, y or n? ");
            string Response2 = Console.ReadLine();
            Console.Write("\n Do you want to implement Buzz, y or n? ");
            string Response3 = Console.ReadLine();
            Console.Write("\n Do you want to implement Bang, y or n? ");
            string Response4 = Console.ReadLine();
            Console.Write("\n Do you want to implement Bong, y or n? ");
            string Response5 = Console.ReadLine();
            Console.Write("\n");

            for (var i = 1; i <= MaxNum; i = i + 1)
            {
                List<string> valueList = new List<string>();
                if (Response == "y") if (i % 3 == 0)
                {
                    valueList.Add("Fizz");
                }
                if (Response2 == "y") if (i % 13 == 0)
                {
                    valueList.Add("Fezz");
                }
                if (Response3 == "y") if (i % 5 == 0)
                {
                    valueList.Add("Buzz");
                }
                if (Response4 == "y") if (i % 7 == 0)
                {
                    valueList.Add("Bang");
                }
                if (Response5 == "y") if (i % 11 == 0)
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