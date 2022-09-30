using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // DONE - First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // DONE - Create a list called numbers that will hold integers
            // DONE - Create an string variable with an empty string initializer - name it str

            // DONE - using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // DONE - and Exceptions will be thrown 
            // DONE - Below we will set this up 
            // ------------------------------------------------------------------------------

            var arr = new char[] { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };
            var numbers = new List<int>();
            var str = "";

            //only did this so I could see the beginning list and then the change on the console - not necessary for lesson
                Console.WriteLine("-------------------Original Character Array--------------------");
                Console.WriteLine();
                arr.ToList().ForEach(x => Console.Write($"{x}   "));
                Console.WriteLine(); Console.WriteLine();
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine();

            // DONE - START HERE:

            // DONE - Make a foreach loop to iterate through your character array


            // DONE - Now create a try catch


            // DONE - Inside your try block
            // DONE - set your string variable to each array element in your char[] to .ToString()
            // DONE - Now, using int.Parse, parse your string variable and store in an int variable
            // DONE - Then add each int to your list

            foreach (var item in arr)
            {
                try
                {
                    str = item.ToString();
                    var number = int.Parse(str);

                    numbers.Add(number);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Unable to Parse '{item}'"); //character will be the name of each item in your collection
                }
            }

            // DONE - catch your Exception:
            // DONE - in the scope of your catch you can use the following, 

            // DONE - Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection

            Console.WriteLine();
            Console.WriteLine("---------------Numbers List---------------------");
            Console.WriteLine();

            foreach (var num in numbers)
            {
                Console.Write($"{num}   ");
            }
            Console.WriteLine();
        }
    }
}
