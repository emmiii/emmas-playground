using LeapYear_ClassLibrary;
using NUnit.Framework;
using FluentAssertions;

namespace LeapYearTest
{
    [TestFixture]
    public class LeapYearShould
    {
        [Test]
        [TestCase(1, false)]
        [TestCase(2, false)]
        [TestCase(3, false)]
        [TestCase(4, true)]
        [TestCase(5, false)]
        [TestCase(6, false)]
        [TestCase(7, false)]
        [TestCase(8, true)]
        public void YearDivisibleBy4IsLeapYear(int year, bool expected)
        {
            LeapYear.CalculateLeapYear(year).Should().Be(expected);
        }

        [Test]
        [TestCase(400)]
        [TestCase(800)]
        public void YearDivisibleBy400IsLeapYear(int year)
        { 
            LeapYear.CalculateLeapYear(year).Should().BeTrue();
        }

        [Test]
        [TestCase(100)]
        [TestCase(150)]
        [TestCase(200)]
        public void YearDivisibleBy100ButNot400IsNotLeapYear(int year)
        {
            LeapYear.CalculateLeapYear(year).Should().BeFalse();
        }

        [Test]
        [TestCase(1997, false)]
        [TestCase(1996, true)]
        [TestCase(1600, true)]
        [TestCase(1800, false)]
        public void TestExamples(int year, bool expected) 
        {
            LeapYear.CalculateLeapYear(year).Should().Be(expected);
        }
    }
}
