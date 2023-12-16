using System;

namespace calculator
{
    class MathsOperations
    {
        public int add(int a, int b)
        {
            return (a + b);
        }
        public int minus(int a, int b)
        {
            return (a - b);
        }
        public int multiply(int a, int b)
        {
            return (a * b);
        }
        public double divide(int a, int b)
        {
            try
            {
                return (a / b);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MathsOperations mo = new MathsOperations();

            int operationChoice, firstNumber, secondNumber;

            Console.WriteLine("-----Welcome to basic calculator-----");
            Console.Write("Enter your first number:");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your second number:");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose operation(reply with a number)  \n 1. + \n 2. - \n 3. * \n 4. /");
            operationChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------");

            switch (operationChoice)
            {
                case 1:
                    Console.WriteLine("{0} + {1} = {2} ", firstNumber, secondNumber, mo.add(firstNumber, secondNumber));
                    break;
                case 2:
                    Console.WriteLine("{0} - {1} = {2} ", firstNumber, secondNumber, mo.minus(firstNumber, secondNumber));
                    break;
                case 3:
                    Console.WriteLine("{0} * {1} = {2} ", firstNumber, secondNumber, mo.multiply(firstNumber, secondNumber));
                    break;
                case 4:
                    Console.WriteLine("{0} / {1} = {2} ", firstNumber, secondNumber, mo.divide(firstNumber, secondNumber));
                    break;
                default:
                    Console.WriteLine("Wrong input!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
