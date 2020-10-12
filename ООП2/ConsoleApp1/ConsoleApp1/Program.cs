using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TV.Menu();
            int i = 0;
            string g = "null";
            while (g != "/")
            {
                g = Convert.ToString(Console.ReadLine());
                if (g == "+")
                    i = TV.SwitchUp();
                else
                if (g == "-")
                    i = TV.SwitchDown();
                else
                if (g == "*")
                    i = TV.SwitchSelect();
                else
                    if (g != "/")
                {
                    Console.WriteLine("Неправильное действие. Повторите еще раз.");
                    TV.Menu();
                }

                Console.WriteLine("Текущий канал - " + i);
            }
            Console.WriteLine("Вы выключили телевизор");
            Console.ReadKey();
        }
    }
}
