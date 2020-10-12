using System;

namespace ConsoleApp1
{
    class Sub
    {
        public string IndNumber;
        public string Name;
        internal string Familiya;
        protected internal string Otchestvo;
        public string Adres;
        public string NumberCard;
        public string TimeMezGorod;
        public string TimeGorod;
    }

    class PetShop
    {
        public string Name;
        internal string Price;
        protected internal string Animal;
        internal string Pol;
        public string Kolichestvo;
    }

    class Buyer
    {
        public string Name;
        internal string Familiya;
        protected internal string Otchestvo;
        public string Adres;
        public string NumberCard;
        public string BankSchet;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            while (choice != 4)
            {
                Console.WriteLine("\n Покупатель - 1 \n Абонент - 2 \n Зоомагазин - 3 \n Выход - 4");
                Console.WriteLine();
                Console.Write("Ваш выбор: ");

                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Buyer Buyer = new Buyer();
                    Console.WriteLine("Пример: Name Familiya Otchestvo Adres NumberCard BankSchet");
                    Buyer.Name = "" + Console.ReadLine();
                    Buyer.Familiya = "" + Console.ReadLine();
                    Buyer.Otchestvo = "" + Console.ReadLine();
                    Buyer.Adres = "" + Console.ReadLine();
                    Buyer.NumberCard = "" + Console.ReadLine();
                    Buyer.BankSchet = "" + Console.ReadLine();

                    Console.WriteLine
                    ("\nПокупатель:\n" + "Имя: " + Buyer.Name + " Фамилия: " + Buyer.Familiya + " Отчество: " + Buyer.Otchestvo + " Адрес: " + Buyer.Adres + " Номер кредит. карты " + Buyer.NumberCard + " Номер банк. счета: " + Buyer.BankSchet);
                }
                else if (choice == 2)
                {
                    Sub Sub = new Sub();
                    Console.WriteLine("Пример: IndNumber Name Familiya Otchestvo Adres NumberCard TimeMezGorod TimeGorod");
                    Sub.IndNumber = "" + Console.ReadLine();
                    Sub.Name = "" + Console.ReadLine();
                    Sub.Familiya = "" + Console.ReadLine();
                    Sub.Otchestvo = "" + Console.ReadLine();
                    Sub.Adres = "" + Console.ReadLine();
                    Sub.NumberCard = "" + Console.ReadLine();
                    Sub.TimeMezGorod = "" + Console.ReadLine();
                    Sub.TimeGorod = "" + Console.ReadLine();

                    Console.WriteLine
                    ("\nАбонент:\n" + " Идентификационный номер: " + Sub.IndNumber + " Имя: " + Sub.Name + " Фамилия: " + Sub.Familiya + " Отчество: " + Sub.Otchestvo + " Адрес: " + Sub.Adres + " Номер кредит. карты: " + Sub.NumberCard + " Время междугород. переговоров: " + Sub.TimeMezGorod + " Время город. переговоров: " + Sub.TimeGorod);
                }
                else if (choice == 3)
                {
                    PetShop PetShop = new PetShop();
                    Console.WriteLine("Пример: Animal Price Name Pol Kolichesvo");
                    PetShop.Name = "" + Console.ReadLine();
                    PetShop.Price = "" + Console.ReadLine();
                    PetShop.Animal = "" + Console.ReadLine();
                    PetShop.Pol = "" + Console.ReadLine();
                    PetShop.Kolichestvo = "" + Console.ReadLine();

                    Console.WriteLine
                   ("\nЗоо Магазин:\n" + " Животное: " + PetShop.Animal + " Цена: " + PetShop.Price  + " Имя: " + PetShop.Name + " Пол: " + PetShop.Pol + " Количество: " + PetShop.Kolichestvo);

                }
            }
        }
    }
}
