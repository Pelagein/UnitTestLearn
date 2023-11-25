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
            string Word = "Stady"; //Слово в котором хотим поменять буквы.
            char OldLetter = 'a'; //Буква которую хотим заменить.
            char NewLetter = 'u'; // Новая буква.
            string expected = "Study"; //Ожидаемый результат.
            string actual = Replace.MethodLetterReplace(Word,OldLetter,NewLetter);//Использование метода, для получения результата.
            Assert.AreEqual(expected, actual); //Сравнение ожидаемого и реального результата программы.
        }
    }
}