using System;


/*a Console Application program to check if the given 10 number inputs are even 
or odd. Prompt the user to enter the numbers, and display whether it's even or odd.*/
namespace Labsheet
{
    class program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter number " + (i + 1));
                int num = int.Parse(Console.ReadLine());

                int tot = num % 2;

                if (tot == 0)
                {
                    Console.WriteLine(num + " Is even number.");
                }
                else
                {
                    Console.WriteLine(num + " Is odd number.");
                }
            }


            Console.ReadKey();
        }

    }

}
