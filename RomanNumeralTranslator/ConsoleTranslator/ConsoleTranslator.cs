using System;
using RomanNumeralTranslator;

namespace ConsoleTranslator
{
    /// <summary>
    /// Translated Roman numeral strings through the command line.
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Reads in Roman numeral strings from the command line, translates them, and prints out the result.
        /// </summary>
        /// <param name="args">The strings to translated (read in from the command line).</param>
        public static void Main(string[] args)
        {
            foreach (string numerals in args) // Iterates through each string read in from the command line.
            {
                int translation = Translator.Translate(numerals); // Translates the string of Roman numerals
                if (translation < 0) // The string contains invalid characters
                {
                    Console.WriteLine("Invalid input");
                }
                else // The string does not contain invalid characters
                {
                    Console.WriteLine("{0} = {1}", numerals, translation);
                }
            }
        }
    }
}
