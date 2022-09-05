using RomanNumeralToNumbers.Models;
using FluentAssertions;

namespace RomanNumeralToNumbers.Tests;

public class RomantoNumberTests
{
    private ConvertRomanToNumber ConvertRomanToNumber;

    [SetUp]
    public void Setup()
    {
        ConvertRomanToNumber = new ConvertRomanToNumber();
    }

    [Test]
    public void Get_Numeral_Value_From_Roman_1_10()
    {
        RomanNumeric RN1 = new RomanNumeric('I', 1);
        RomanNumeric RN2 = new RomanNumeric('V', 5);
        RomanNumeric RN3 = new RomanNumeric('X', 10);
        RomanNumeric RN4 = new RomanNumeric('L', 50);
        RomanNumeric RN5 = new RomanNumeric('C', 100);
        RomanNumeric RN6 = new RomanNumeric('D', 500);
        RomanNumeric RN7 = new RomanNumeric('M', 1000);

        var romannumerals = new List<RomanNumeric>
            {
                 RN1, RN2, RN3, RN4, RN5, RN6, RN7
            };

        string[] sRomanToConvert = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "CCCLXV", "XLV", "CCLIV", "MMCCCLXV" };

        ConvertRomanToNumber.GetNumericValue(romannumerals, sRomanToConvert);
        //Assert.Pass();
    }

    [Test]
    public void Get_Numeral_Value_For_specific_Roman_Letters()
    {
        RomanNumeric RN1 = new RomanNumeric('I', 1);
        RomanNumeric RN2 = new RomanNumeric('V', 5);
        RomanNumeric RN3 = new RomanNumeric('X', 10);
        RomanNumeric RN4 = new RomanNumeric('L', 50);
        RomanNumeric RN5 = new RomanNumeric('C', 100);
        RomanNumeric RN6 = new RomanNumeric('D', 500);
        RomanNumeric RN7 = new RomanNumeric('M', 1000);

        var romannumerals = new List<RomanNumeric>
            {
                 RN1, RN2, RN3, RN4, RN5, RN6, RN7
            };

        ConvertRomanToNumber.GetNumericFromRoman(romannumerals, "I").Should().Be(1);
        ConvertRomanToNumber.GetNumericFromRoman(romannumerals, "II").Should().Be(2);
        ConvertRomanToNumber.GetNumericFromRoman(romannumerals, "III").Should().Be(3);
        ConvertRomanToNumber.GetNumericFromRoman(romannumerals, "IV").Should().Be(4);
        ConvertRomanToNumber.GetNumericFromRoman(romannumerals, "V").Should().Be(5);
        ConvertRomanToNumber.GetNumericFromRoman(romannumerals, "VI").Should().Be(6);
        ConvertRomanToNumber.GetNumericFromRoman(romannumerals, "VII").Should().Be(7);
        ConvertRomanToNumber.GetNumericFromRoman(romannumerals, "VIII").Should().Be(8);
        ConvertRomanToNumber.GetNumericFromRoman(romannumerals, "IX").Should().Be(9);
        ConvertRomanToNumber.GetNumericFromRoman(romannumerals, "X").Should().Be(10);
        ConvertRomanToNumber.GetNumericFromRoman(romannumerals, "").Should().Be(0);
        ConvertRomanToNumber.GetNumericFromRoman(romannumerals, "DV").Should().Be(505);
        ConvertRomanToNumber.GetNumericFromRoman(romannumerals, "MMMDCCXCV").Should().Be(3795);
    }
}
