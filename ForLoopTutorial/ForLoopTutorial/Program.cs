using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;

namespace ForLoopTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            //Line
            for (int i = 1; i <= limit; i++)
            {
                Console.WriteLine("*");
            }
            Console.WriteLine();

            //Square
            for (int x = 0; x < limit; x++)
            {
                for (int y = 0; y < limit; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Triangle
            for (int i = 0; i < limit; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            
        }
    }
}
