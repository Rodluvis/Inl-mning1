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
                        resultList.Add(num1 + num3);
                        Console.WriteLine(num1 + num3);
                        break;
                    case "-":
                        resultList.Add(num1 - num3);
                        Console.WriteLine(num1 - num3);
                        break;
                    case "*":
                        resultList.Add(num1 * num3);
                        Console.WriteLine(num1 * num3);
                        break;
                    case "/":
                        resultList.Add(num1 / num3);
                        Console.WriteLine(num1 / num3);
                        break;
                }

                Console.WriteLine("Press \"x\" to exit and to print out the sum of all previous calculations" +
                         "\nPress any other key to continue your chain of calculations.");

                string exit = Console.ReadLine().ToLower();
                switch (exit)
                {
                    case "x":
                        Console.WriteLine($"The sum of all previous calculations is {resultList.Sum()}");
                        running = false;
                        return;
                }
            }

            /* bool running = true;
             while (running)
             {
                 int[] results = new int[size];
                 for (int i = 0; i < size; i++)
                 {
                     // calculation here 
                     results[i] = resultOfCalculation;
                 }
                 int sum = results.Sum();
                 Console.WriteLine("Welcome to Yulia's calculator");
                 Console.WriteLine("Choose two operators:");
                 string[] operators = new string[2];
                 for (int i = 0; i < 2; i++)
                 {
                     operators[i] = Console.ReadLine();
                 }

                                 var intList = new List<int>();
                 string sUserInput = "";
                 var slist = new List<string>();*/

        }
    }
}

