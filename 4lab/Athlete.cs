using System;
using System.Collections.Generic;
using System.Text;

namespace _4lab
{
    class Athlete : Person
    {
        private string sport;
        private int rang;

        public Athlete() { }

        public Athlete (string name, string surname, int age, string is_married, string sport, int rang)
          : base (name, surname, age, is_married)
        {
            this.sport = sport;
            this.rang = rang;

        }
        public string Sport
        {
            set
            {
                sport = value;
            }
        }

        public int Rang
        {
            set
            {
                rang = value;
            }
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
            if (sport != default)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sport: " + sport);
            }
            if (rang != default)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Rang: " + rang);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
