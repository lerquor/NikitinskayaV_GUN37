using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            int[] fibonacciNumbers = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };

            for (int i = 0; i < fibonacciNumbers.Length; i++)
            {
                Console.WriteLine(fibonacciNumbers[i]);
            }

            //Task 2

            for (int j = 2; j <= 20; j += 2)
            {
                Console.WriteLine(j);

            }

            //Task 3

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine();

            }

            //Task 4

            string password = "qwerty";
            string userInput;
            bool isRight = false;

            do
            {
                Console.Write("Введите пароль");
                userInput = Console.ReadLine();
                if (userInput == password)
                {
                    isRight = true;
                    Console.WriteLine("The password is correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }
            }
            while (!isRight);
        }
    }
}
