using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FizzBuzzLib.Tests
{
    [TestClass()]
    public class GetFizzBuzzTests
    {
        [TestMethod()]
        public void Test_For_Fizz()
        {
            var test = new GetFizzBuzz();
            var expected = new List<string> { "1", "2", "Fizz" };
            var actual = test.FizzBuzz(1, 3);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Test_For_Buzz()
        {
            var test = new GetFizzBuzz();
            var expected = new List<string> { "1", "2", "Fizz", "4", "Buzz" };
            var actual = test.FizzBuzz(1, 5);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Test_For_FizzBuzz()
        {
            var test = new GetFizzBuzz();
            var expected = new List<string> { "1", "2", "Fizz", "4", "Buzz",
            "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };
            var actual = test.FizzBuzz(1, 15);
            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}