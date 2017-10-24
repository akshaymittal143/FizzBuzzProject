using System.Collections.Generic;

namespace FizzBuzzLib
{
    public class GetFizzBuzz
    {
        public List<string> FizzBuzz(int input1, int input2)
        {
            List<string> results = new List<string>();
            for (int number = input1; number <= input2; number++)
            {
                //Console.WriteLine("{0}", i % 15 == 0 ? "FizzBuzz" : (i % 3 == 0 ? "Fizz" : (i % 5 == 0 ? "Buzz" : i.ToString())));                

                string result = ""; //intialize string variable to store the result           
                if (number % 3 == 0) result = "Fizz";  //checking if divible by 3                
                if (number % 5 == 0) result = result + "Buzz"; //checking if diving by 5 and if divisible by 3 and 5 =FizzBuzz              
                if (result.Length == 0) result = number.ToString();   //print number if not divisble by 3 or 5               
                results.Add(result); //Console.WriteLine(result);
            }
            return results; //returning List of string results
        }
    }
}
