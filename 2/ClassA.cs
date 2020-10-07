using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    class ClassA
    {
        Person person1;
        Person person2;
        Person person3;
        public ClassA() { }
        public ClassA(Person person1)
        {
            this.person1 = person1;
        }
        public ClassA(Person person1, Person person2)
        {
            this.person1 = person1;
            this.person2 = person2;
        }
        public ClassA(Person person1, Person person2, Person person3)
        {
            this.person1 = person1;
            this.person2 = person2;
            this.person3 = person3;
        }

        public void Method()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            if (person1 != default)
            {
                Console.WriteLine("Person 1: ");
                Console.WriteLine("Name: " + person1.Name);
                Console.WriteLine("Surname: " + person1.Surname);
            }
            if (person2 != default)
            {
                Console.WriteLine("Person 2: ");
                Console.WriteLine("Name: " + person2.Name);
                Console.WriteLine("Surname: " + person2.Surname);
            }
            if (person3 != default)
            {
                Console.WriteLine("Person 3: ");
                Console.WriteLine("Name: " + person3.Name);
                Console.WriteLine("Surname: " + person3.Surname);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
