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
    class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator _pointsCalculator;
        [SetUp]
        public void SetUp()
        {
            _pointsCalculator = new DemeritPointsCalculator();
        }
        [Test]
        [Ignore("Exceptiony ")]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_SpeedIsBelowZeroOrExceedsMaxSpeed_ThrowArgumentOutOfRangeException(int speed)
        {

            Assert.That(() => _pointsCalculator.CalculateDemeritPoints(speed),
                        Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
        [Test]
        [TestCase(0,0)]
        [TestCase(64,0)]
        [TestCase(66, 0)]
        [TestCase(70,1)]
        [TestCase(165,20)]
        public void CalculateDemeritPoints_SpeedIsGreaterOrEqualToZero_ReturnsAmountOfDemeritPoints(int speed, int expectedDemeritPoints)
        {
            var result = _pointsCalculator.CalculateDemeritPoints(speed);

            Assert.That(result, Is.EqualTo(expectedDemeritPoints));
        }
    }
}
