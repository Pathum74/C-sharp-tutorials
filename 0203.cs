/*
Build an application to store and display the temperatures of a week using an array. Create a class named ‘TemperatureTracker’ 
with an array to store daily temperatures. Implement a method to display the temperatures. Instantiate an object, input temperatures, 
and display the weekly temperature report.
*/

using System;

namespace TempTracker
{

    class TemperatureTracker
    {
        static void display()
        {
            string[] days = new string[] { "sunday", "monday", "tuesday", "wensday", "thurseday", "friday", "saturday" };
            int[] tt = new int[7];
            for (int i = 0; i < tt.Length; i++)
            {
                Console.WriteLine(days[i] + " temperature ");
                tt[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n-Weekly temperature report-\n");

            for (int j = 0; j < tt.Length; j++)
            {
                Console.WriteLine(days[j] + " " + tt[j]);
            }

        }
        static void Main()
        {
            TemperatureTracker ttker = new TemperatureTracker();
            TemperatureTracker.display();

            Console.ReadKey();
        }
    }

}
