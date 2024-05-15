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
    }
}
