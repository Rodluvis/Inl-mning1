using System;
using System.Collections.Generic;
using System.Linq;

namespace Inlämning1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Inlämning1";
            List<int> resultList = new List<int>();
            bool running = true;
            while (running)
            {
                Console.WriteLine("Enter first operator");
                string operand1 = Console.ReadLine();
                Console.WriteLine("Enter second operator");
                string operand2 = Console.ReadLine();

                Console.WriteLine("Enter first term");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second term");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter third term");
                int num3 = Convert.ToInt32(Console.ReadLine());
                int result = 0;
                switch (operand1)
                {
                    case "+":
                        num1 += num2;
                        break;
                    case "-":
                        num1 -= num2;
                        break;
                    case "*":
                        num1 *= num2;
                        break;

                    case "/":
                        num1 /= num2;
                        break;
                }

                switch (operand2)
                {
                    case "+":
                        result = num1 + num3;

                        Console.WriteLine($"The result of your input is: {result}");
                        break;
                    case "-":
                        result = num1 - num3;

                        Console.WriteLine($"The result of your input is: {result}");
                        break;
                    case "*":
                        result = num1 * num3;

                        Console.WriteLine($"The result of your input is: {result}");
                        break;
                    case "/":
                        result = num1 / num3;
                        Console.WriteLine($"The result of your input is: {result}");
                        break;
                }
                resultList.Add(result);
                if (result <100)
                {
                   Console.WriteLine("The sum is less then a hundred.");
                }

                if (result == 100)
                {
                    Console.WriteLine("Cool, now you have a hundred, clap clap");
                }
               if (result >100)
                {
                    Console.WriteLine("More then a hundred");
                }
                Console.WriteLine("Another try? " +
                    "\nPress ENTER to continue." +
                    "\nPress \"x\" to exit and to print out the sum of all previous calculations");

                string exit = Console.ReadLine().ToLower();
                switch (exit)
                {
                    case "x":
                        Console.WriteLine($"Thank you for playing. The sum of all round is: {resultList.Sum()}");
                        running = false;
                        return;
                }
            }

        }
    }
}

