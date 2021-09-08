using System;
using Operations;

namespace Program
{

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Write 2 numbers");
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Select one from next operations: '+', '-', '*', '/'");
            string operation = Console.ReadLine();
            float res = MathLogic.Calculate(num1, num2, operation);
            Console.WriteLine(res);
        }
    }
}
