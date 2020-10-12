using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TV
    {
        public static int a;
        public static int SwitchUp()
        {
            a++;
            if (a > 10)
                a = 0;
            return a;
        }
        public static int SwitchDown()
        {
            a--;
            if (a < 0)
                a = 10;
            return a;               
        }
        public static int SwitchSelect()            
        {
            try
            {
                Console.WriteLine("Выберите канал");
                a = Convert.ToInt32(Console.ReadLine());
                while (a < 0 || a > 10)
                {
                    Console.WriteLine("Несуществующий канал. Выберите еще раз:");
                    a = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (FormatException)
            {
                Menu();
            }
            return a;
        }
        public static void Menu()
        {
            Console.WriteLine("+: Вперед");
            Console.WriteLine("-: Назад");
            Console.WriteLine("*: Выбрать канал");
            Console.WriteLine("/: Выключить телевизор");
            Console.WriteLine();
            Console.WriteLine("Доступные каналы от 0 до 10");
        }
    }
}

