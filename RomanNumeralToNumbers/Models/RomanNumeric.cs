using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralToNumbers.Models
{
    public class RomanNumeric
    {
        public RomanNumeric(char romanchar, int numericvalue)
        {
            RomanChar = romanchar;
            NumericValue = numericvalue;
        }

        public char RomanChar { get; set; }

        public int NumericValue { get; set; }
    }
}
