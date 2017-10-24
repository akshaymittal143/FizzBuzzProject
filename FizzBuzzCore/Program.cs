using FizzBuzzLib;
using System;
using System.Collections.Generic;

namespace FizzBuzzCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------- Starting Fizz Buzz Console App -----------------------");
            //calling fuction to print FizzBuzz
            PrintFizzBuzz();
            Console.ReadLine();
        }

        /// <summary>
        /// This function check for correct input and print the sequence by calling lib function.
        /// </summary>
        public static void PrintFizzBuzz()
        {
            int minNumber, maxNumber; //intialize varible to store inputs
            try
            {
                Console.Write("Enter a Minimum Number:");
                minNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a Maximum Number:");
                maxNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e} Exception occured");
                //printing type of exception occured
                throw;
            }

            if (minNumber > maxNumber) //checking for proper range
            {
                Console.WriteLine("Try again! Enter Proper Range numbers");
                PrintFizzBuzz();
            }

            GetFizzBuzz result = new GetFizzBuzz();
            List<string> results = new List<string>();
            results = result.FizzBuzz(minNumber, maxNumber); //calling library function

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------- Ending Fizz Buzz -----------------------------------");

        }

    }
}
