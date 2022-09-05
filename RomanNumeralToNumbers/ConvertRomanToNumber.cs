
using RomanNumeralToNumbers.Models;

namespace RomanNumeralToNumbers
{
    public class ConvertRomanToNumber
    {
        public void GetNumericValue(List<RomanNumeric> romannumerals, string[] sRomanToConvert)
        {
            int iValue;
            foreach (var s in sRomanToConvert)
            {
                var pNumeric = 0;
                var cNumeric = 0;
                iValue = 0;
                char cRomanChar;

                for (var i = 0; i < s.Length; i++)
                {
                    cRomanChar = s[i];
                    foreach (var o in romannumerals)
                    {
                        if (cRomanChar == o.RomanChar)
                            cNumeric = o.NumericValue;
                    }

                    if (i > 0 && cNumeric > pNumeric)
                        iValue += cNumeric - pNumeric * 2;
                    else
                        iValue += cNumeric;
                    pNumeric = cNumeric;
                }
                Console.WriteLine($"The value of {s}: " + iValue);
            }
        }

        public int GetNumericFromRoman(List<RomanNumeric> romannumerals, string roman)
        {
            var pNumeric = 0;
            var cNumeric = 0;
            var iValue = 0;
            char cRomanChar;
            if (roman.Length > 0 && !String.IsNullOrEmpty(roman))
            {
                for (var i = 0; i < roman.Length; i++)
                {
                    cRomanChar = roman[i];
                    foreach (var o in romannumerals)
                    {
                        if (cRomanChar == o.RomanChar)
                            cNumeric = o.NumericValue;
                    }

                    if (i > 0 && cNumeric > pNumeric)
                        iValue += cNumeric - pNumeric * 2;
                    else
                        iValue += cNumeric;
                    pNumeric = cNumeric;
                }
                //Console.WriteLine($"The value of {roman}: " + iValue);
            }
            return iValue;
        }

    }
}
