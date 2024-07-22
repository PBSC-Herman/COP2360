using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            string input1 = Console.ReadLine();
            
            Console.WriteLine("Enter the second number:");
            string input2 = Console.ReadLine();

            Divide(input1, input2);
        }

        static void Divide(string str1, string str2)
        {
            int num1 = Convert.ToInt32(str1);
            int num2 = Convert.ToInt32(str2);

            int result = num1 / num2;

            Console.WriteLine($"The result of dividing {num1} by {num2} is: {result}");
        }
    }
}
