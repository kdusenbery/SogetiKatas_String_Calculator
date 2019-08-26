using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Calculator
{
    class Project
    {
        static void Main(string[] args)
        {
            StringCalculator stringCalculator = new StringCalculator();

            while (true)
            {
                Console.WriteLine("Please insert a string of comma delimited numbers, \n\r" +
                    "or type 'get called count' to see how many calculations have been made.");

                var input = Console.ReadLine();

                if (input == "get called count")
                {
                    Console.WriteLine(stringCalculator.GetCalledCount());
                }
                else
                {
                    Console.WriteLine(stringCalculator.Add(input));
                }
            }
        }
    }
}
