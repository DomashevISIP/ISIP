using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = new string[100, 100];
            FileStream file1 = new FileStream("text1.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file1);
            string text = reader.ReadToEnd();
            FileStream file2 = new FileStream("text2.txt", FileMode.Create);
            int arrayNumberX = 1; int arrayNumberY = 1;
            int[] arrayLenghtX = new int[100];
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ' && text[i] != '\n') array[arrayNumberX, arrayNumberY] += text[i];
                else
                if (text[i] == ' ') { arrayNumberX++; arrayLenghtX[arrayNumberY]++; }
                else { arrayNumberX = 1; arrayNumberY++; }
            }
            int arrayLenghtY = arrayNumberY;
            StreamWriter writer = new StreamWriter(file2);
            writer.Write(array[1, 1] + " ?");

            for (int j = 2; j <= arrayLenghtX[1] + 1; j++)
            {
                writer.Write(" " + array[j, 1]);
            }

            for (int i = 2; i <= arrayLenghtY; i++)
            {
                for (int j = 1; j <= arrayLenghtX[i] + 1; j++)
                {
                    if (j != 1) writer.Write(" ");
                    writer.Write(array[j, i]);
                }
            }

            writer.Close();
            Console.WriteLine("Процесс завершен");
            Console.ReadLine();
        }
    }
}
