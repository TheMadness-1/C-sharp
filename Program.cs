using System;
using NUnit.Framework;

namespace Test1
{
    class Program
    {
        static void Main()
        {
            string[] operations = new string[] {"+", "-", "/", "*"};
            Console.WriteLine("Write 2 numbers");
            float num1 = float.Parse(Console.ReadLine()); 
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Select one from next operations: '+', '-', '*', '/'");
            string operation = Console.ReadLine();
            int index = Array.IndexOf(operations, operation);
            if (index < 0 || (operation == "/" && num2 == 0))
            {
                Console.WriteLine("Operation is not available or dive on 0");
                return;
            }
            switch(operation)
            {
                case "+":
                    Add(num1, num2);
                    break;
                case "-":
                    Sub(num1, num2);
                    break;
                case "*":
                    Mult(num1, num2);
                    break;
                case "/":
                    Div(num1, num2);
                    break;

            }
        }

        public static void Add(float a, float b)
        {
            float res = a + b;
            Console.WriteLine("Add result is " + res);
        }
        public static void Sub(float a, float b)
        {
            float res = a - b;
            Console.WriteLine("Sub result is " + res);
        }
        public static void Mult(float a, float b)
        {
            float res = a * b;
            Console.WriteLine("Mult result is " + res);
        }
        public static void Div(float a, float b)
        {
            float res = a / b;
            Console.WriteLine("Div result is" + res);
        }

        ////Tests
     [Test]
        public void AddTest()
        {
            Assert.AreEqual(5, Add(2, 3));
        }
     [Test]
        public void SubTest()
        {
            Assert.AreEqual(5, Add(8, 3));
        }
     [Test]
        public void MultTest()
        {
            Assert.AreEqual(5, Add(2.5, 2));
        }
     [Test]
        public void DivTest()
        {
            Assert.AreEqual(5, Add(10, 2));
        }
    }
}
