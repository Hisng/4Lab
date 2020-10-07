using System;
using System.Collections.Generic;
using System.Text;

namespace _4lab
{
    class Person
    {
        protected string name;
        protected string surname;
        protected int age;
        protected string is_married;
        public Person() { }
        public Person(string name, string surname, int age, string is_married)
        {
            this.name = name;
            this.surname= surname;
            this.age= age;
            this.is_married= is_married;
        }
        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;            
        }
        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        public Person(string name, string surname, string is_married)
        {
            this.name = name;
            this.surname = surname;
            this.is_married = is_married;
        }
        public void Method()
        {
            if (name != default)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Name: " + name);
            }
            if (surname != default)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Surname: " + surname);
            }
            if (age != default)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Age: " + age);
            }
            if (is_married != default)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Is married: " + is_married);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
