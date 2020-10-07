using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the product`s key:");
            string product_key = Convert.ToString(Console.ReadLine());
            ApplicationLicense license = new ApplicationLicense(product_key);
            license.Method();
        }
    }
}
