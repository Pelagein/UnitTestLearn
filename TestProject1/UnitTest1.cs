using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitLearn;
namespace UnitTestLearn
{
    [TestClass]
    public class UnitTestLearn
    {
        [TestMethod]
        public void TestMethodReplace()
        {
            //Исходные данные.
            string Word="Stady";
            char OldLetter = 'a';
            char NewLetter = 'u';
            string actual = "Study";
            //Получение значения с помощью тестируемого метода.
            Replace replaceWord = new Replace();
            string expected = replaceWord.MethodLetterReplace(Word, OldLetter, NewLetter);
            //Сравнение полуенного результата (expected) с ожидаемым результатом (actual).
            Assert.AreEqual(expected,actual);
        }
    }
}