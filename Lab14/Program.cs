using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Program
    {
        static void Main()
        {
            Cat cat = new Cat();
            cat.ShowInfo();
            cat.Say();

            Console.WriteLine();

            Dog dog = new Dog();
            dog.ShowInfo();
            dog.Say();

            Console.ReadKey();
        }

        abstract class Animal
        {
            public string Name { get; set; }
            public string Voice { get;  set; }

            public void ShowInfo()
            {
                Console.WriteLine(Name);
                Say();
            }

            public void Say()
            {
                Console.WriteLine(Voice);
            }
        }

        private class Cat : Animal
        {
            public Cat()
            {
                Name = "Кошка";
                Voice = "Мяу";
            }
            public new void Say()
            {
                Console.WriteLine("Мяу!!!");
            }
        }

        private class Dog : Animal
        {
            public Dog()
            {
                Name = "Собака";
                Voice = "Гав";
            }
            public new void Say()
            {
                Console.WriteLine("Гав!!!");
            }
        }

    }
}
