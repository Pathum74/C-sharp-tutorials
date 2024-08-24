using System;

/*Console Application program to print the first N terms of the 
Fibonacci series. Prompt the user to enter the value of N. (Use recursion)*/

namespace Labsheet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n term of fibonacci ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci term : ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Fibo(i) + " ");

            }
            Console.ReadLine();
        }

        static int Fibo(int nn)
        {
            if (nn <= 1)
            {
                return nn;
            }
            else
            {
                return Fibo(nn - 1) + Fibo(nn - 2);
            }

        }

       
    }


}
