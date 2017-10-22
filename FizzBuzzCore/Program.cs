using FizzBuzzLib;
using System;
using System.Collections.Generic;

namespace FizzBuzzCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Maximum Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            GetFizzBuzz result = new GetFizzBuzz();
            List<string> results = new List<string>();
            results = result.FizzBuzz(number);
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
