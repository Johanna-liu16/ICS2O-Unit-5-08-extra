// Created by: Johanna Liu
// Created on: May 2022
//
// This file contains the JS functions for index.html

using System;

class Program
{
    public static void Main(string[] args)
    {
    
        int counter1 = 0;
        int counter2 = 0;
        var answer = 1;
        var remainder = 0;

        Console.Write("Input a number: ");
        counter1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a number: ");
        counter2 = Convert.ToInt32(Console.ReadLine());

            for (int num = counter1; num > counter2; num = num - counter2) {
                remainder = num - counter2;
                answer = answer + 1;
            }
        

        Console.WriteLine("The answer is: " + counter1 + " ÷ " + counter2 + " = " + answer + " " + "The remainder is " + remainder);
        Console.Write("\nDone.");
    }
}