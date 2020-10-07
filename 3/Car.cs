using System;
using System.Collections.Generic;
using System.Text;

namespace _3
{
    class Car
    {
        private string owner;
        private int age;
        public Car() { }
        public Car(string owner, int age)
        {
            this.owner = owner;
            this.age = age;
        }
        public Car(int age)
        {
            this.age = age;
        }
        public Car(string owner)
        {
            this.owner = owner;
        }

        public string Owner
        {
            get
            {
                return owner;
            }
            set
            {
                owner = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 0 && value < 100)
                {
                    age = value;
                }
            }
        }
    }
}
