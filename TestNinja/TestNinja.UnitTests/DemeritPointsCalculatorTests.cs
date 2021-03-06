﻿using System;
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
            Assert.That(() => dpc.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(64, 0)]
        [TestCase(65, 0)]
        [TestCase(66, 0)]
        [TestCase(70, 1)]
        [TestCase(75, 2)]
        public void CalculateDemeritPoints_SpeedIsLessThanOrEqualToZero_ReturnZero(int speed, int expectedResult)
        {
            var calculator = new DemeritPointsCalculator();
            var points = calculator.CalculateDemeritPoints(speed);
            Assert.That(points, Is.EqualTo(expectedResult));

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
