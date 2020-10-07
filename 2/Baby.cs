using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    class Baby : Person
    {
        private int age;

        public Baby() { }
        public Baby(int age)
        {
            this.age = age;
        }
        public void Method()
        {
            Console.WriteLine("You are in class Baby");
        }
    }
}
