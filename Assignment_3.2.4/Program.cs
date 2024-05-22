/*
Write a function that takes 4 numbers as input to calculate the total and average.
(Make use of params array to pass arguments and out parameters to return both total and average to main method).
Test Data:
Enter the First number: 10
Enter the Second number: 15
Enter the third number: 20
Enter the fourth number: 30

Expected Output:
The average of 10 , 15 , 20 , 30 is: 18.75
The total is 75
*/
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace Assignment_3._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] inputArray = {0, 0, 0, 0};
            Console.WriteLine("Enter the First number: ");
            inputArray[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the First number: ");
            inputArray[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the First number: ");
            inputArray[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the First number: ");
            inputArray[3] = Convert.ToInt32(Console.ReadLine());

            double[] returnArray = TotalAverage(inputArray);
            Console.WriteLine($"The total is {returnArray[0]} and the average is {returnArray[1]}");

        }

        static double[] TotalAverage(double[] TotalInputArray)
        {
           double total = TotalInputArray[0] + TotalInputArray[1] + TotalInputArray[2] + TotalInputArray[3];
           double totalAverage = total/ TotalInputArray.Length;

           double[] outputArray = {total, totalAverage};
           return outputArray;            
        }
        

    }
}
