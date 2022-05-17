using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //try
        //{
        //    Console.WriteLine("Pick a number.");
        //    int numberOne = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Pick a second number.");
        //    int numberTwo = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Dividing the two...");
        //    int numberThree = numberOne / numberTwo;
        //    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
        //    Console.ReadLine();
        //}
        //catch (FormatException ex)
        //{
        //    Console.WriteLine("Don't be an idiot, type a whole number.");
        //    return;
        //}
        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine("Please don't divide by zero.");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //finally
        //{
        //    Console.ReadLine();
        //}




        //Exception Assignment 

        List<int> numbers= new List<int>() { 100, 75, 50, 25, 5 };
        int numberOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Pick a number to divide each number in the list.");
        int numberTwo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dividing the two...");
        int numberThree = numberOne / numberTwo;

        for (int numberOne = 0; numberOne < numbers.Length; numberOne++)
        {
            {
                numbers= numberOne + ;
            }
        }

        Console.WriteLine();
        Console.ReadLine();

    }
}



