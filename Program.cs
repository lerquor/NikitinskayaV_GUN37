using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            int[] fibonacciNumbers = { 0, 1, 1, 2, 3, 5, 8, 13 };

            //Task 2
            string[] Months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            //Task 3
            int[][] Array234 = new int[3][] { new[] { 2, 3, 4 }, new[] { 4, 9, 16 }, new[] { 8, 27, 64 } };

            //Task 4
            double[][] tripleArray = new double[3][] { new[] { 1.0, 2, 3, 4, 5 }, new[] { Math.E, Math.PI }, new[] {Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000)} };

            //Task 5
            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };

            Array.Copy(array, 0, array2, 0, 2);

            //Task 6
            
            Array.Resize(ref array, array.Length * 2);
            
        }
    }
}
