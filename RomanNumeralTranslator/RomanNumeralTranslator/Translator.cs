/* The RomanNumeralTranslator program takes in a string of Roman numerals
 * and converts it to Arabic numerals (in the form of an int).
 * Author: Connor Barnes
 * Email: Connor.W.Barnes@gmail.com
 * 
 * General Algorithm:
 * 1) Define which characters are valid Roman numerals and the value that each symbol represents
 * 2) Iterate through each symbol in the string of Roman numerals and calculate the sum of their values
 *     a) Ensure that there are no invalid characters in the string of Roman numerals
 *     b) If a symbol has a value less than the value of the next symbol, then the two symbols are
 *        interpreted as one symbol whose value is the difference between the two original symbols
 *     c) If a symbol has a value greater than or equal to the value of the next symbol, then the they
 *        are considered independent
 * 3) Return the calculated sum in Arabic numerals (in the form of an int)
 */

namespace RomanNumeralTranslator
{
    /// <summary>
    /// Translates Roman numerals in to Arabic numerals.</summary>
    /// <remarks>
    /// Translates either a string of Roman numerals or a single character.</remarks>
    public static class Translator
    {
        // 1) Define which characters are valid Roman numerals and the value that each symbol represents
        public static char[] Symbols = new char[] { 'I', 'V', 'X', 'L', 'C', 'D', 'M' }; // All valid Roman numeral symbols
        public static int[] Values = new int[] { 1, 5, 10, 50, 100, 500, 1000 }; // Corresponding values

        /// <summary>
        /// Translates the specified string of Roman numerals to Arabic numerals.</summary>
        /// <param name="numeralString">The string of Roman numerals to translate.</param>
        /// <returns>
        /// The value represented by the specified string of Roman numerals (or
        /// -1 if any of the characters in the specified string are not valid
        /// Roman numeric symbols).</returns>
        public static int Translate(string numeralString)
        {
            // 2) Iterate through each symbol in the string of Roman numerals and calculate the sum of their values
            int sum = 0;
            int valueA, valueB;
            for (int i = 0; i < numeralString.Length; i++)
            {
                valueA = GetValue(numeralString[i]);
                if (valueA < 0) // Ensures that there are no invalid characters in the string of Roman numerals
                {
                    return -1;
                }
                if (i + 1 < numeralString.Length)
                {
                    valueB = GetValue(numeralString[i + 1]);
                }
                else
                {
                    valueB = 0;
                }
                if (valueA < valueB) // The value of the current symbol is less than the value of the next symbol
                {
                    // This will never execute if the next symbol is invalid
                    valueA = valueB - valueA; // Calculates the difference between the two values
                    i++; // Prevents processing the second symbol twice
                }
                sum += valueA;
            }
            // 3) Return the calculated sum in Arabic numerals (in the form of an int)
            return sum;
        }

        /// <summary>
        /// Returns the value of the specified Roman numeric symbol.</summary>
        /// <param name="symbol">The Roman numeric symbol whose value will be returned.</param>
        /// <returns>
        /// Returns -1 if the specified char is not a Roman numeric symbol.</returns>
        public static int GetValue(char symbol)
        {
            for (int i = 0; i < Symbols.Length; i++)
            {
                if (symbol.Equals(Symbols[i]))
                {
                    return Values[i];
                }
            }
            return -1;
        }
    }
}

