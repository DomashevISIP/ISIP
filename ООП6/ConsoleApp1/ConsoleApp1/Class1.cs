using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        public int num1;
        public int num2;
        public Class1()
        {

        }
        public Class1(int number)
        {
            num1 = number;
        }
        public Class1(int number, int number2)
        {
            num1 = number;
            num2 = number2;
        }
        public void Print()
        {
            Console.WriteLine(num1 + " | " + num2);
        }
    }
}
