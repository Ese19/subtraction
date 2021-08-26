using System;

namespace subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            int secondNum;
            int result;

            Console.WriteLine("Enter the first number");
            firstNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            secondNum = int.Parse(Console.ReadLine());

            result = firstNum - secondNum;
            Console.WriteLine("The answer is " + result);
        }
    }
}
