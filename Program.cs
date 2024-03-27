using System;
//Coded by: Diaz, Jestro R.
//From: BSCPE 1-1

namespace OOPASSIGNMENT2NIJES
{
   internal class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n <= 100; n++)
            {
                if (n % 15 == 0) 
                {
                    Console.WriteLine("Hello!, Goodbye<3");
                }
                else
                {
                    if (n % 3 == 0) 
                    {
                        Console.WriteLine("Hello!");
                    } else
                    {
                        if (n % 5 == 0) 
                        {
                            Console.WriteLine("Goodbye<3");
                        }
                        else
                        {
                            Console.WriteLine(n);
                        }
                    }
                }
            }
        }
    }
}