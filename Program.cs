using System;
using NUnit.Framework;

namespace Test1
{
    [TestFixture]
    public class Program
    {
        static void Main()
        {
            string[] operations = new string[] { "+", "-", "/", "*" };
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
            switch (operation)
            {
                case "+":
                    Console.WriteLine(Add(num1, num2)); 
                    break;
                case "-":
                    Console.WriteLine(Sub(num1, num2));
                    break;
                case "*":
                    Console.WriteLine(Mult(num1, num2));
                    break;
                case "/":
                    Console.WriteLine(Div(num1, num2));
                    break;

            }
        }

        public static float Add(float a, float b)
        {
            return a + b;
        }
        public static float Sub(float a, float b)
        {
            return a - b;
        }
        public static float Mult(float a, float b)
        {
            return a * b;
        }
        public static float Div(float a, float b)
        {
            return a / b;
        }


        //Tests
        [Test]
        public void AddTest()
        {
            Assert.AreEqual(5, Add(2, 3));
        }
        [Test]
        public void SubTest()
        {
            Assert.AreEqual(5, Sub(8, 3));
        }
        [Test]
        public void MultTest()
        {
            Assert.AreEqual(5, Mult(2.5f, 2));
        }
        [Test]
        public void DivTest()
        {
            Assert.AreEqual(5, Div(10, 2));
        }
    }
}
