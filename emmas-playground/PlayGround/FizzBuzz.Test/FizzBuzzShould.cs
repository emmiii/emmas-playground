using NUnit.Framework;
using FluentAssertions;
using FizzBuzz_ClassLibrary;

namespace FizzBuzzTest
{
    [TestFixture]
    public class FizzBuzzShould
    {
        [Test]
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(4, "4")]
        public void ConvertNumberToString(int number, string expectedConverted)
        {
            var result = FizzBuzz.Convert(number);
            result.Equals(expectedConverted).Should().BeTrue();
        }

        [Test]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        [TestCase(669)]
        public void ConvertDivisibleBy3ToFizz(int number)
        {
            var result = FizzBuzz.Convert(number);
            result.Equals("Fizz").Should().BeTrue();
        }

        [Test]
        [TestCase(10)]
        [TestCase(20)]
        public void ConvertDivisibleBy5ToBuzz(int number)
        {
            var result = FizzBuzz.Convert(number);
            result.Equals("Buzz").Should().BeTrue();
        }

        [Test]
        [TestCase(60)]
        public void ConvertDivisibleBy3And5ToFizzBuzz(int number)
        {
            var result = FizzBuzz.Convert(number);
            result.Equals("FizzBuzz").Should().BeTrue();
        }

        [Test]
        [TestCase(3, "FizzFizz")]
        [TestCase(6, "Fizz")]
        public void ExtraFizzWhenDivisibleNumberContains3(int number, string expectedConverted)
        {
            var result = FizzBuzz.Convert(number);
            result.Equals(expectedConverted).Should().BeTrue();
        }

        [Test]
        [TestCase(5, "BuzzBuzz")]
        [TestCase(10, "Buzz")]
        public void ExtraFizzWhenDivisibleNumberContains5(int number, string expectedConverted)
        {
            var result = FizzBuzz.Convert(number);
            result.Equals(expectedConverted).Should().BeTrue();
        }
    }
}
