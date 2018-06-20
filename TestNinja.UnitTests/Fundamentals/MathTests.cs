using NUnit.Framework;
using TestNinja.Fundamentals;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class MathTests
    {
        private Math _math;
        // SetUp
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]

        public void Add_WhenCalled_ReturnsTheSumOfArguments()
        {
            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }
        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(2, 1, 2)]
        [TestCase(2, 2, 2)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
        [Test]
        public void Max_SecondArgumentIsGreater_ReturnsSecondArgument()
        {
            var result = _math.Max(1, 2);

            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Max_ArgumentsAreEqual_ReturnsSecondArgument()
        {
            var result = _math.Max(2, 2);

            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNUmbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));
        }
    }
}
