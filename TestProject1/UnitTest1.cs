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
            //�������� ������.
            string Word="Stady";
            char OldLetter = 'a';
            char NewLetter = 'u';
            string actual = "Study";
            //��������� �������� � ������� ������������ ������.
            Replace replaceWord = new Replace();
            string expected = replaceWord.MethodLetterReplace(Word, OldLetter, NewLetter);
            //��������� ���������� ���������� (expected) � ��������� ����������� (actual).
            Assert.AreEqual(expected,actual);
        }
    }
}