using System;

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

    class Class3
    {
        public double a;
        public double b;
        public double c;
        public Class3(int line1, int line2, int line3)
        {
            a = line1; b = line2; c = line3;
            if ((a + b > c) && (b + c > a) && (c + a > b))
                Console.WriteLine("Треугольник возможен");
            else
                Console.WriteLine("Треуголник не возможен");

            double A = (Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c))) * (180 / Math.PI);
            double B = (Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c))) * (180 / Math.PI);
            double C = (Math.Acos((Math.Pow(b, 2) + Math.Pow(a, 2) - Math.Pow(c, 2)) / (2 * b * a))) * (180 / Math.PI);

            Console.WriteLine("Угол A = {0:0.000}", A);
            Console.WriteLine("Угол B = {0:0.000}", B);
            Console.WriteLine("Угол C = {0:0.000}", C);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("-------------------------------");

            Class1 argument = new Class1();
            argument.Print();
            Class1 argument1 = new Class1(228);
            argument1.Print();
            Class1 argument2 = new Class1(1488, 1337);
            argument2.Print();

            Console.WriteLine("");
            Console.WriteLine("-------------------------------");

            Class2 text1 = new Class2();
            Class2 text2 = new Class2();
            Class2 text3 = new Class2();
            text1.Write();
            text1.Print();
            text2.Write("Привет мир");
            text2.Print();
            text3.Write("Привет мир, меня зовут....");
            text3.Print();

            Console.WriteLine("");
            Console.WriteLine("-------------------------------");

            Class3 triangle = new Class3(15, 7, 1);
            Console.WriteLine("-------------------------------");
            Class3 triangle2 = new Class3(12, 5, 13);

            Console.WriteLine("");
            Console.WriteLine("-------------------------------");

            Console.ReadLine();
        }
    }
}
