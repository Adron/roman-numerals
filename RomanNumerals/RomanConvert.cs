using System.Text;

namespace RomanNumerals;

public static class RomanConvert
{
    public static string BuildRomanNumeral(int n)
    {
        if (n == 0) return string.Empty;

        return new Dictionary<int, string>
        {
            {1000, "M"}, {900, "CM"}, {500, "D"}, {400, "CD"},
            {100, "C"}, {90, "XC"}, {50, "L"}, {40, "XL"},
            {10, "X"}, {9, "IX"}, {5, "V"}, {4, "IV"}, {1, "I"}
        }.Where(p => n >= p.Key).Select(p => p.Value + BuildRomanNumeral(n - p.Key)).FirstOrDefault()!;
    }

    public static int ConvertFromRoman(string roman)
    {
        if (roman == string.Empty) return 0;

        return new Dictionary<string, int>
        {
            {"M", 1000}, {"CM", 900}, {"D", 500}, {"CD", 400},
            {"C", 100}, {"XC", 90}, {"L", 50}, {"XL", 40},
            {"X", 10}, {"IX", 9}, {"V", 5}, {"IV", 4}, {"I", 1}
        }.Where(p => roman.StartsWith(p.Key)).Select(p => p.Value + ConvertFromRoman(roman.Substring(p.Key.Length))).FirstOrDefault();
    }
}