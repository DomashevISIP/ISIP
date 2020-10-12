using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
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
}
