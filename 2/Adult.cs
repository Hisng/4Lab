using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    class Adult : Person
    {
        private int age;

        public Adult() { }
        public Adult(int age)
        {
            this.age = age;
        }
        public void Method()
        {
            Console.WriteLine("You are in class Adult");
        }
    }
}
