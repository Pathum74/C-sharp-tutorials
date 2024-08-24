using System;

/*Console Application program to calculate the sum of all numbers from 1 to a 
given positive integer. Prompt the user to enter a positive integer and display the sum. 
If the user inputs a negative value it should display “ERROR”. */

namespace Labsheet
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number ");
            int posnum = int.Parse(Console.ReadLine());
            int sum = 0;

            if (posnum < 0)
            {
                Console.WriteLine("Error!!! \nGive a positive number");
            }
            else
            {
                int posnums = 1 + posnum;

                int[] numss = new int[posnums];
                for (int i = 0; i < numss.Length; i++)
                {
                    sum = sum + i;
                }
                Console.WriteLine("Sum of positive number between 0 & " + posnum + " is " + sum);

            }

            Console.ReadKey();
        }

    }

}
