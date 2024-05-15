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
}