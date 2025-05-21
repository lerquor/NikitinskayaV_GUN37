using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, write the first number");
        if (!int.TryParse(Console.ReadLine(), out int a))
        {
            Console.WriteLine("Error!");
            return;
        }
        Console.WriteLine("Please, write the second number");

        if (!int.TryParse(Console.ReadLine(), out int b))
        {
            Console.WriteLine("Error!");
            return;
        }
        Console.WriteLine("Please, write a sign (&, | or ^)");
        var sign = Console.ReadLine();
        var number = 0;

        if (sign.Length > 1 || sign.Length == 0)
        {
            Console.WriteLine("Wrong sign");
            return;
        }
        switch (sign[0])
        {
            case '|':
                number = a | b;
                Console.WriteLine(number + " " + Convert.ToString(number, 2) + " " + Convert.ToString(number, 16));
                break;
            case '&':
                number = a & b;
                Console.WriteLine(number + " " + Convert.ToString(number, 2) + " " + Convert.ToString(number, 16));
                break;
            case '^':
                number = a ^ b;
                Console.WriteLine(number + " " + Convert.ToString(number, 2) + " " + Convert.ToString(number, 16));
                break;
            default: 
                Console.WriteLine("Wrong sign!");
                break;
        }
    }
}
