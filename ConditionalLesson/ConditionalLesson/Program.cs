using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            // int.Parse - Converting string to int
            int age = int.Parse(Console.ReadLine());
            string kapisanan = string.Empty;
            // bool - true or false
            bool married = false;
            
            if (age < 18)
            {
                kapisanan = "BINHI";
            }
            else if (age >= 18)
            {
                Console.WriteLine("Are you married? (Y/N) ");
                string result = Console.ReadLine();
                // == - equal to
                married = result == "Y";
                
            }
            // && - and
            if (kapisanan == string.Empty && married)
            {
                kapisanan = "BUKLOD";
            }
                // ! - not (!= - not equal to)
            else if (kapisanan == string.Empty && !married)
            {
                kapisanan = "KADIWA";
            }

            Console.WriteLine(kapisanan);
            // Console.ReadKel() - Pause
            Console.ReadKey();


        }
    }
}
