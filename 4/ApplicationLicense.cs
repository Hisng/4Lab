using System;
using System.Collections.Generic;
using System.Text;

namespace _4
{
    class ApplicationLicense
    {
        private string key;
        private string[] ProKeys = { "1234-4321", "3214-3124", "2143-3421" };
        private string[] TrialKeys = { "2345-5432", "3425-3452", "5432-2345" };
        public ApplicationLicense(string key)
        {
            this.key = key;
        }
        public void Method()
        {
            for(int i = 0; i < ProKeys.Length; i++)
            {
                if (key == ProKeys[i])
                {
                    AllowPro();
                    break;
                }
            }
            for (int i = 0; i < TrialKeys.Length; i++)
            {
                if (key == TrialKeys[i])
                {
                    AllowTrial();
                    break;
                }
            }
            if(key == "")
            {
                AllowCommon();
            }
        }
        private void AllowPro()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("          Congratulations!!!");
            Console.WriteLine("You have proffesional versin of App.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        private void AllowTrial()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("        Congratulations");
            Console.WriteLine("You have trial versin of App.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        private void AllowCommon()
        {
            Console.WriteLine("You have common versin of App.");
        }
    }
}
