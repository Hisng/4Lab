using System;

namespace _4lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Athlete athlete = new Athlete("Nikita", "Strogalev", 18, "No", "Track&Field", 1);
            athlete.Method();
            Person person = athlete;
            person.Method();
        }
    }
}
