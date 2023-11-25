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
            string Word = "Stady"; //����� � ������� ����� �������� �����.
            char OldLetter = 'a'; //����� ������� ����� ��������.
            char NewLetter = 'u'; // ����� �����.
            string expected = "Study"; //��������� ���������.
            string actual = Replace.MethodLetterReplace(Word,OldLetter,NewLetter);//������������� ������, ��� ��������� ����������.
            Assert.AreEqual(expected, actual); //��������� ���������� � ��������� ���������� ���������.
        }
    }
}