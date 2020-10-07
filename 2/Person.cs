using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    class Person
    {
        protected string name;
        protected string surname;


        public Person() 
        {

        }
        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public void Method()
        {
            Console.WriteLine("You are in class Person");
        }
    }
}
