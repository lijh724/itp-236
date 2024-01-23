using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

/*
 * Program Objective:
 * Input - have user populate an array with 5 temperatures (loop)
 * Display a menu to ask user if they want to convert temperature between F and C or find the average temperature (switch/if else)
 * Use methods for conversion and average calculation
 * Output results to user
 * */

namespace ReviewAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create List of temperatures using user input
            List<double> temperatures = new List<double>();
            for (int i = 0; i < 5;  i++)
            {
                WriteLine("Enter a temperature: ");
                temperatures.Add(Convert.ToDouble(ReadLine()));
                WriteLine();
            }

            // creates options for user to choose from
            WriteLine("Select an option (Enter the corresponding number):\n 1 - Convert from Fahrenheit to Celsius" +
                "\n 2 - Find the average temperature\n");

            switch(ReadLine())
            {
                case "1":
                    WriteLine();
                    FahrenheitToCelsius(temperatures);
                    break;
                case "2":
                    WriteLine();
                    AverageTemperature(temperatures);
                    break;
            }

            ReadKey();
        }

        static void FahrenheitToCelsius(List<double> t)
        {
            for (int i = 0; i < t.Count; i++)
            {
                WriteLine("{0}: {1}°F --> {2}°C\n", i + 1, t.ElementAt(i), ((t.ElementAt(i) - 32) / 1.8).ToString("F2"));
            }
        }

        static void AverageTemperature(List<double> t)
        {
            WriteLine("The average of all temperatures is: " + t.Average());
        }
    }
}
