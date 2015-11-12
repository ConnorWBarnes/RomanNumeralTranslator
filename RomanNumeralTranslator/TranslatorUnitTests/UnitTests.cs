using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralTranslator;

namespace TranslatorUnitTests
{
    [TestClass]
    public class UnitTests
    {
        /// <summary>
        /// Tests the GetValue() method with valid and invalid arguments.
        /// </summary>
        [TestMethod]
        public void GetValueTest()
        {
            // Test valid arguments
            Assert.AreEqual(Translator.GetValue('I'), 1);
            Assert.AreEqual(Translator.GetValue('V'), 5);
            Assert.AreEqual(Translator.GetValue('X'), 10);
            Assert.AreEqual(Translator.GetValue('L'), 50);
            Assert.AreEqual(Translator.GetValue('C'), 100);
            Assert.AreEqual(Translator.GetValue('D'), 500);
            Assert.AreEqual(Translator.GetValue('M'), 1000);

            // Test invalid arguments
            Assert.AreEqual(Translator.GetValue('i'), -1);
            Assert.AreEqual(Translator.GetValue('v'), -1);
            Assert.AreEqual(Translator.GetValue('x'), -1);
            Assert.AreEqual(Translator.GetValue('l'), -1);
            Assert.AreEqual(Translator.GetValue('c'), -1);
            Assert.AreEqual(Translator.GetValue('d'), -1);
            Assert.AreEqual(Translator.GetValue('m'), -1);
            Assert.AreEqual(Translator.GetValue('A'), -1);
            Assert.AreEqual(Translator.GetValue('E'), -1);
            Assert.AreEqual(Translator.GetValue('F'), -1);
            Assert.AreEqual(Translator.GetValue('4'), -1);
        }

        /// <summary>
        /// Tests the Translate() method with strings containing valid characters and strings containing invalid characters.
        /// </summary>
        [TestMethod]
        public void TranslateTest()
        {
            // Test strings with valid characters
            Assert.AreEqual(Translator.Translate("I"), 1);
            Assert.AreEqual(Translator.Translate("IX"), 9);
            Assert.AreEqual(Translator.Translate("XI"), 11);
            Assert.AreEqual(Translator.Translate("MMXV"), 2015);
            Assert.AreEqual(Translator.Translate("MCMXCIX"), 1999);
            Assert.AreEqual(Translator.Translate("CCVII"), 207);
            Assert.AreEqual(Translator.Translate("MLXVI"), 1066);
            Assert.AreEqual(Translator.Translate("MCMIV"), 1904);
            Assert.AreEqual(Translator.Translate("MCMLIV"), 1954);
            Assert.AreEqual(Translator.Translate("MCMXC"), 1990);
            Assert.AreEqual(Translator.Translate("MMXIV"), 2014);
            Assert.AreEqual(Translator.Translate("XXII"), 22);

            // Test strings with invalid characters
            Assert.AreEqual(Translator.Translate("i"), -1);
            Assert.AreEqual(Translator.Translate("sXX"), -1);
            Assert.AreEqual(Translator.Translate("mCMiV"), -1);
            Assert.AreEqual(Translator.Translate("4XjIF"), -1);
            Assert.AreEqual(Translator.Translate("XiI"), -1);
            Assert.AreEqual(Translator.Translate("MMxVIK"), -1);
            Assert.AreEqual(Translator.Translate("IXA"), -1);
            Assert.AreEqual(Translator.Translate("DEADBEEF"), -1);
        }
    }
}
