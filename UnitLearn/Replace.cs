﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitLearn
{
    public static class Replace
    {

        public static string MethodLetterReplace(string Word,char OldLetter,char NewLetter) 
        {
            string NewWord="";
            foreach (char E in Word) 
            {
                if (E == OldLetter) { NewWord += NewLetter; }
                else { NewWord += E; }
            }
            return NewWord;
        }
    }
}
