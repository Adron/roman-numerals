using System.Text;

namespace RomanNumerals;

public static class RomanConvert
{
    public static string BuildRomanNumeral(int n)
    {
        var result = new StringBuilder();
        
        // Define Roman numeral symbols and their corresponding values
        int[] values = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
        string[] symbols = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
        
        for (var i = 0; i < values.Length; i++)
        {
            while (n >= values[i])
            {
                result.Append(symbols[i]);
                n -= values[i];
            }
        }

        return result.ToString();
    }
}