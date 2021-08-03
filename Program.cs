using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Looping to 255

            // for(int i = 1; i <= 255; i++)
            // {
            //     Console.WriteLine(i);
            // }

            
            // for(int i = 1; i <= 100; i++)
            // {
                
            //     if (i % 3 == 0 || i % 5 == 0)
            //         {
            //             if (i % 15 != 0)
            //         {
            //     Console.WriteLine(i);
            //     }
            //     }
            // }
          for(int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine( i + "FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + "Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + "Buzz");
                }
                else 
                {
                    Console.WriteLine(i);
                }
            }

            

        }
    }
}

    

