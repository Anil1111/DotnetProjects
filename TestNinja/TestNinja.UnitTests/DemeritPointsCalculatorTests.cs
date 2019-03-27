using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_SpeedIsLessThan0OrGreaterThanMaxSpeed_ReturnsArgOutOfRangeExp(int speed)
        {
            var dpc = new DemeritPointsCalculator();
            Assert.That(() => dpc.CalculateDemeritPoints(speed), Throws.Exception);
        }

        [Test]
        [TestCase(65)]
        [TestCase(1)]
        public void CalculateDemeritPoints_SpeedIsLessThanOrEqualToZero_ReturnZero(int speed)
        {
            var dpc = new DemeritPointsCalculator();
            var result = dpc.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CalculateDemeritPoints_OnePointFor5KMOverSpeedLimit_ReturnDemeritPoints()
        {
            var dpc = new DemeritPointsCalculator();
            var result = dpc.CalculateDemeritPoints(80);
            Assert.That(result, Is.EqualTo(3));
        }



    }
}
