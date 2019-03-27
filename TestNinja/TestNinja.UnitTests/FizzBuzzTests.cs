using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void FizzBuzz_DivisibleBy3And5_ReturnsFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void FizzBuzz_DivisibleBy3_ReturnsFizz()
        {
            var result = FizzBuzz.GetOutput(6);
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void FizzBuzz_DivisibleBy5_ReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(10);
            Assert.That(result, Is.EqualTo("Buzz"));
        }
    }
}

