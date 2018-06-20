using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class FizzBuzzTests
    {
        [Test]
        [TestCase(15, "FizzBuzz")]
        [TestCase(9, "Fizz")]
        [TestCase(10,"Buzz")]
        [TestCase(4, "4")]
        public void GetOutput_DependingOnInputDivisibility_ReturnsProperString(int number, string expectedString)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo(expectedString));
        }
    }
}
