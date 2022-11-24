using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово в котором хотите заменить буквы:");
            string Word = Console.ReadLine();
            Console.WriteLine("Введите букву для замены:");
            char OldLetter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите новую букву:");
            char NewLetter = Convert.ToChar(Console.ReadLine());
            Replace replace = new Replace();
            Word=replace.MethodLetterReplace(Word,OldLetter,NewLetter);
            Console.WriteLine($"Результат замены: {Word} ");
        }
    }
}
