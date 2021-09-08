using System;

namespace Operations
{
    public class MathLogic
    {
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

        public static float Calculate(float num1, float num2, string operation)
        {
            string[] operations = new string[] { "+", "-", "/", "*" };
            int index = Array.IndexOf(operations, operation);
            if (index < 0 || (operation == "/" && num2 == 0))
            {
                throw new Exception("Wrong parameters");
            }
            float res = 0;
            switch (operation)
            {
                case "+":
                    res = Add(num1, num2);
                    break;
                case "-":
                    res = Sub(num1, num2);
                    break;
                case "*":
                    res = Mult(num1, num2);
                    break;
                case "/":
                    res = Div(num1, num2);
                    break;
            }
            return res;
        }
    }
}