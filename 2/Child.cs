using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    class Child : Person
    {
        private int age;

        public Child() { }
        public Child(int age)
        {
            this.age = age;
        }

        public void Method()
        {
            Console.WriteLine("You are in class Baby");
        }
    }
}
