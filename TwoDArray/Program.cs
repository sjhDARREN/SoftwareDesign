//
// ICT2106 Software Design - 2D array example
//
// Main program.
//
// Author: Nicholas Sheppard
//
using System;

namespace TwoDArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // create and fill a 2 x 3 array of integers
            ITwoDArray<int> array = new TwoDArrayGeneric<int>(2, 3);
            array.Set(0, 0, 9); array.Set(0, 1, 4); array.Set(0, 2, 1);
            array.Set(1, 0, 2); array.Set(1, 1, 5); array.Set(1, 2, 3);

            ITwoDArray<int> array2 = new TwoDArrayGeneric<int>(3, 3);
            array2.Set(0, 0, 1); array2.Set(0, 1, 2); array2.Set(0, 2, 3);
            array2.Set(1, 0, 4); array2.Set(1, 1, 5); array2.Set(1, 2, 6);
            array2.Set(2, 0, 7); array2.Set(2, 1, 8); array2.Set(2, 2, 9);


            ITwoDArray<String> array3 = new TwoDArrayGeneric<String>(2, 3);
            array3.Set(0, 0, "Sarah"); array3.Set(0, 1, null); array3.Set(0, 2, "Yixin");
            array3.Set(1, 0, null); array3.Set(1, 1, null); array3.Set(1, 2, "Faizal");


            // display the array in row major order
            ITwoDIterator<int> iter = array.CreateRowMajorIterator();
            ITwoDIterator<int> iter2 = array2.CreateFirstIterator();
            ITwoDIterator<string> iter3 = array3.CreateSecondIterator();


            Console.WriteLine("Original iterator");
            while (!iter.IsDone())
            {
                Console.Write(iter.Current() + " ");
                iter.Next();
            }

            Console.WriteLine("");

            Console.WriteLine("First iterator");
            while (!iter2.IsDone())
            {
                Console.Write(iter2.Current() + " ");
                iter2.Next();
            }

            Console.WriteLine("");

            Console.WriteLine("Second iterator");
            while (!iter3.IsDone())
            {
                Console.Write(iter3.Current() + " ");
                iter3.Next();
            }
















            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
