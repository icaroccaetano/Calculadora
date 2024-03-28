using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main()
        {
            int op;
            double a, b;
            bool control = true;

            
            Console.WriteLine("Welcome to the Calculator!");

            while (control)
            {
                Console.WriteLine("Choose an option:");
                Console.Write("  1 - Sum\n  2 - Subtraction\n  3 - Multiplication\n  4 - Division\n  5 - Rest of Division\n  6 - Exponentiation\n  0 - End Program\n");
                op = int.Parse(Console.ReadLine());


                if (op == 0)
                {
                    control = false;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\nEnding program...\n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                else if (op != 1 && op != 2 && op != 3 && op != 4 && op != 5 && op!= 6)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nERROR: Invalid Input\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                else
                {
                    Console.WriteLine("Insert the fist number");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insert the second number");
                    b = double.Parse(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();

                    switch (op)
                    {
                        case 1:
                            Console.WriteLine(a + " + " + b + " = " + (a + b));
                            break;
                        case 2:
                            Console.WriteLine(a + " - " + b + " = " + (a - b));
                            break;
                        case 3:
                            Console.WriteLine(a + " * " + b + " = " + (a * b));
                            break;
                        case 4:
                            Console.WriteLine(a + " / " + b + " = " + (a / b));
                            break;
                        case 5:
                            Console.WriteLine(a + " % " + b + " = " + (a % b));
                            break;
                        case 6:
                            Console.WriteLine(a + " ^ " + b + " = " + (Math.Pow(a,b)));
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}