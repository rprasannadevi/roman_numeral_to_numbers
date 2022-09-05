using RomanNumeralToNumbers;
using RomanNumeralToNumbers.Models;

RomanNumeric RN1 = new('I', 1);
RomanNumeric RN2 = new('V', 5);
RomanNumeric RN3 = new('X', 10);
RomanNumeric RN4 = new('L', 50);
RomanNumeric RN5 = new('C', 100);
RomanNumeric RN6 = new('D', 500);
RomanNumeric RN7 = new('M', 1000);

var romannumerals = new List<RomanNumeric>
{
    RN1, RN2, RN3, RN4, RN5, RN6, RN7
};

string[] sRomanToConvert = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "CCCLXV", "XLV", "CCLIV", "MMCCCLXV" };

var convertRomanToNumerals = new ConvertRomanToNumber();

convertRomanToNumerals.GetNumericValue(romannumerals, sRomanToConvert);

string? sRoman;
Console.Write("Please Enter a Roman Numeral: ");
sRoman = Console.ReadLine();

int iNumericValue;
if (sRoman != null)
{
    iNumericValue = convertRomanToNumerals.GetNumericFromRoman(romannumerals, sRoman);
    Console.WriteLine($"The value of {sRoman}: " + iNumericValue);
}
else
    Console.WriteLine("The input Roman String is Null or Empty.");