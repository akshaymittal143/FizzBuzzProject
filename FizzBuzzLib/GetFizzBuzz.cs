using System.Collections.Generic;

namespace FizzBuzzLib
{
    public class GetFizzBuzz
    {
        public List<string> FizzBuzz(int input)
        {
            List<string> results = new List<string>();
            for (int number = 1; number <= input; number++)
            {
                //Console.WriteLine("{0}", i % 15 == 0 ? "FizzBuzz" : (i % 3 == 0 ? "Fizz" : (i % 5 == 0 ? "Buzz" : i.ToString())));

                //intialize string variable to empty
                string result = "";
                //checking if divible by 3
                if (number % 3 == 0) result = "Fizz";
                //checking if diving by 5 and if divisible by 3 and 5 =FizzBuzz
                if (number % 5 == 0) result = result + "Buzz";
                //print number if not divisble by 3 or 5
                if (result.Length == 0) result = number.ToString();
                //Console.WriteLine(result);
                results.Add(result);
            }
            return results;
        }
    }
}
