/*
Email validation via netlibrary 12.10.2021
*/

using System;

// include .NET Standard library compiled in Windows
using TestNetStandard;

namespace testNet
{
    enum MenuActions : byte
    {
        VALIDATE =1,
        EXIT = 2
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
            }
        }

        private static void Menu()
        {
            Console.WriteLine("Select action:\n1)\tValidate email;\n2)\tExit;");
            var action = (MenuActions)Convert.ToByte(Console.ReadLine());
            switch (action)
            {
                case MenuActions.VALIDATE:
                    ExecValidation();
                    break;
                case MenuActions.EXIT:
                    Environment.Exit(0);
                    break;
            }
        }

        private static bool ExecValidation()
        {
            Console.WriteLine("Enter email");
            string email = Console.ReadLine();
            
            // Using Validation class from included library
            return Validation.Validate(email,
             () => { Console.WriteLine($"\n\x1b[32;1m{email} is validated\x1b[0m\n"); },
             () => { Console.WriteLine($"\n\x1b[31;4m{email} is not validated\x1b[0m\n"); });

        }
    }
}
