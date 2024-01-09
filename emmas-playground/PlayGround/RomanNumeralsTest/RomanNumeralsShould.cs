using NUnit.Framework;
using FluentAssertions;
using RomanNumerals_ClassLibrary;

namespace RomanNumeralsTest
{
    [TestFixture]
    public class RomanNumeralsShould
    {
        [Test]
        public void ReturnIFor1()
        {
            var result = RomanNumerals.GetRomanNumeralString(1);
            result.Equals("I").Should().BeTrue();
        }

        [Test]
        public void ReturnIIFor2()
        {
            var result = RomanNumerals.GetRomanNumeralString(2);
            result.Equals("II").Should().BeTrue();
        }

        [Test]
        public void ReturnIIIFor3()
        {
            var result = RomanNumerals.GetRomanNumeralString(3);
            result.Equals("III").Should().BeTrue(); 
        }

        [Test]
        public void ReturnIVFor4()
        {
            var result = RomanNumerals.GetRomanNumeralString(4);
            result.Equals("IV").Should().BeTrue();
        }

        [Test]
        public void ReturnVFor5()
        {
            var result = RomanNumerals.GetRomanNumeralString(5);
            result.Equals("V").Should().BeTrue(); 
        }

        [Test]
        public void ReturnVIFor6()
        {
            var result = RomanNumerals.GetRomanNumeralString(6);
            result.Equals("VI").Should().BeTrue();
        }

        [Test]
        public void ReturnVIIFor7()
        {
            var result = RomanNumerals.GetRomanNumeralString(7);
            result.Equals("VII").Should().BeTrue();
        }

        [Test]
        public void ReturnVIIIFor8()
        {
            var result = RomanNumerals.GetRomanNumeralString(8);
            result.Equals("VIII").Should().BeTrue();
        }

        [Test]
        public void ReturnIXFor9()
        {
            var result = RomanNumerals.GetRomanNumeralString(9);
            result.Equals("IX").Should().BeTrue();
        }

        [Test]
        public void ReturnXFor10()
        {
            var result = RomanNumerals.GetRomanNumeralString(10);
            result.Equals("X").Should().BeTrue();
        }

        [Test]
        public void ReturnXIFor11()
        {
            var result = RomanNumerals.GetRomanNumeralString(11);
            result.Equals("XI").Should().BeTrue();
        }

        [Test]
        public void ReturnXIVFor14()
        {
            var result = RomanNumerals.GetRomanNumeralString(14);
            result.Equals("XIV").Should().BeTrue();
        }

        [Test]
        public void ReturnXVFor15()
        {
            var result = RomanNumerals.GetRomanNumeralString(15);
            result.Equals("XV").Should().BeTrue();
        }

        [Test]
        public void ReturnXVIIIFor18()
        {
            var result = RomanNumerals.GetRomanNumeralString(18);
            result.Equals("XVIII").Should().BeTrue();
        }

        [Test]
        public void ReturnXIXFor19()
        {
            var result = RomanNumerals.GetRomanNumeralString(19);
            result.Equals("XIX").Should().BeTrue();
        }

        [Test]
        public void ReturnXXVIIFor27()
        {
            var result = RomanNumerals.GetRomanNumeralString(27);
            result.Equals("XXVII").Should().BeTrue();
        }
    }
}
