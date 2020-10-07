using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Adult adult = new Adult();
            adult.Method();
            Person person = adult;
            person.Method();
            person.Name = "Nikita";
            person.Surname = "Strogalev";
            ClassA A = new ClassA(person);
            A.Method();
        }
    }
}
