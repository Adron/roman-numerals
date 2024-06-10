using RomanNumerals;
using NUnit.Framework;

namespace RomanNumeralTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(4, "IV")]
        [TestCase(500, "D")]
        [TestCase(1000, "M")]
        [TestCase(1954, "MCMLIV")]
        [TestCase(1990, "MCMXC")]
        [TestCase(2008, "MMVIII")]
        [TestCase(2014, "MMXIV")]
        [TestCase(3, "III")]
        [TestCase(9, "IX")]
        [TestCase(14, "XIV")]
        [TestCase(44, "XLIV")]
        [TestCase(99, "XCIX")]
        [TestCase(399, "CCCXCIX")]
        [TestCase(444, "CDXLIV")]
        [TestCase(944, "CMXLIV")]
        [TestCase(999, "CMXCIX")]
        [TestCase(1066, "MLXVI")]
        [TestCase(1987, "MCMLXXXVII")]
        [TestCase(2021, "MMXXI")]
        [TestCase(3999, "MMMCMXCIX")]
        public void RomanConvertTests(int value, string expected)
        {
            Assert.That(RomanConvert.BuildRomanNumeral(value), Is.EqualTo(expected));
        }

        [Test]
        [TestCase("", 0)]
        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("VI", 6)]
        [TestCase("VII", 7)]
        [TestCase("VIII", 8)]
        [TestCase("IX", 9)]
        [TestCase("X", 10)]
        [TestCase("XI", 11)]
        [TestCase("XLIV", 44)]
        [TestCase("L", 50)]
        [TestCase("LIX", 59)]
        [TestCase("XCIX", 99)]
        [TestCase("C", 100)]
        [TestCase("CXCIX", 199)]
        [TestCase("CDXLIV", 444)]
        [TestCase("CM", 900)]
        [TestCase("CMXCIX", 999)]
        [TestCase("M", 1000)]
        [TestCase("MCMLIV", 1954)]
        [TestCase("MMXIV", 2014)]
        [TestCase("MMMCMXCIX", 3999)]
        public void ConvertFromRomanTests(string roman, int expected)
        {
            Assert.That(RomanConvert.ConvertFromRoman(roman), Is.EqualTo(expected));
        }
        

    }
}
