using System;

namespace Declaring_and_Initializing_Arrays_and_the_Length_Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // 1. WAY OF INITIALIZING AN ARRAY
            int[] grades = new int[5]; //array that has space for 5 'grade' values 
            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 14;
            grades[3] = 19;
            grades[4] = 20;

            Console.WriteLine($"grade at index 0: {grades[0]}");

            string input = Console.ReadLine();
            //assign value to array 'grades' at index 0, even if initially its 20 like above:
            grades[0] = int.Parse(input);
           Console.WriteLine($"grade at index 0: {grades[0]}");

            // 2. WAY OF INITIALIZING AN ARRAY
            int[] gradesOfMathStudentsClassA = { 13, 7, 16, 17, 11 };

            // 3. WAY OF INITIALIZING AN ARRAY
            int[] gradesOfMathStudentsClassB = new int[] { 13, 8, 2, 19, 16, 18 };

            // GETTING A LENGTHS OF AN ARRAY (INDEX COUNT)
            Console.WriteLine($"Length of gradesOfMathStudentsClassB: {gradesOfMathStudentsClassB.Length}");
            Console.Read();
        }
    }
}
