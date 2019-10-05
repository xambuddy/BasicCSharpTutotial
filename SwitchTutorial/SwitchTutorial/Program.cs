using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwitchTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a letter: ");
            string letter = Console.ReadLine();
            string output = String.Empty;

            switch (letter)
            {
                case "a":
                    output = "Panget";
                    break;
                case "b":
                    output = "Baho";
                    break;
                case "c":
                    output = "Kengkoy";
                    break;

            }

            Console.WriteLine(output);
            Console.ReadKey();

        }
    }
}
