using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Honda honda = new Honda("Accord", "Nikita", 10);
            ClassA classa = new ClassA();
            classa.Method(honda);
            Car car = honda;
            classa.Method(car);
            Car car1 = new Car("Boris");
            classa.Method(car1);
        }
    }
}
