using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitLearn;

namespace UnitTestLearn
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string Word = "Stady";
            char OldLetter = 'a';
            char NewLetter = 'u';
            Replace replaceWord = new Replace();
            string expected = "Study";
            string actual = replaceWord.MethodLetterReplace(Word,OldLetter,NewLetter);
            Assert.AreEqual(expected, actual);
        }
    }
}