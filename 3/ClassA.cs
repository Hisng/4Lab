using System;
using System.Collections.Generic;
using System.Text;

namespace _3
{
    class ClassA
    {
        public void Method(Car car)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            if (car.Owner != null)
            {
                Console.WriteLine("Car owner is: " + car.Owner);
            }
            if (car.Age != default)
            {
                Console.WriteLine("Age of car: " + car.Age);
            }
        }
        public void Method(Porsche car)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            if (car.Owner != null)
            {
                Console.WriteLine("Car owner is: " + car.Owner);
            }
            if (car.Age != default)
            {
                Console.WriteLine("Age of car: " + car.Age);
            }
            if (car.Model != null)
            {
                Console.WriteLine("Model of Porsche: " + car.Model);
            }
        }
        public void Method(Toyota car)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            if (car.Owner != null)
            {
                Console.WriteLine("Car owner is: " + car.Owner);
            }
            if (car.Age != default)
            {
                Console.WriteLine("Age of car: " + car.Age);
            }
            if (car.Model != null)
            {
                Console.WriteLine("Model of Toyota: " + car.Model);
            }
        }
        public void Method(Honda car)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            if (car.Owner != null)
            {
                Console.WriteLine("Car owner is: " + car.Owner);
            }
            if (car.Age != default)
            {
                Console.WriteLine("Age of car: " + car.Age);
            }
            if (car.Model != null)
            {
                Console.WriteLine("Model of Honda: " + car.Model);
            }
        }
    }
}
