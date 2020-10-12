using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class2
    {
        private string line = "Пусто";
        public void Write()
        {

        }
        public void Write(string line2)
        {
            if (line2.Length > 10) line = "Слишком длинная строка";
            else line = line2;
        }
        public void Print()
        {
            Console.WriteLine(line);
        }
    }
}
