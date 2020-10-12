using System;

namespace ConsoleApp1
{
    class Person
    {
        private string name;
        private string surname;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public void Display()
        {
            Console.WriteLine(Name + "_" + Surname);
        }

        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
    }

    class Employee : Person
    {
        private string klass;

        public Employee(string name, string surname, string klas)
            : base(name, surname)
        {
            klass = klas;
        }

        public string Klass
        {
            get { return klass; }
            set { klass = value; }
        }
        public void DisplayE()
        {
            Console.WriteLine(Name + "_" + Surname + "_" + Klass);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Дмитрий", "Сернов");
            Employee emp = new Employee("Андрей", "Попов", "Выпускник");

            p.Display();
            emp.DisplayE();
            Console.ReadKey();
        }
    }
}
