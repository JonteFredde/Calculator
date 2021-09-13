using System;
using System.Threading;
using static System.Console;
using static System.Convert;


namespace Miniräknare
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                WriteLine("Enter the action to be performed");
                WriteLine("Press 1 for Addition");
                WriteLine("Press 2 for Substraction");
                WriteLine("Press 3 for Multiplication");
                WriteLine("Press 4 for Division");
                WriteLine("Press 5 for Modulus");
                WriteLine("Press 6 for Exit");

                var selectMeny = ReadKey(true);

                string input1, input2;
                int FirstNumber, SecondNumber;


                switch  (selectMeny.Key)
                {
                    default:
                        Clear();
                        WriteLine("Invalid selection!");
                        break;

                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        {
                            Clear();
                            WriteLine("You picked Addition");
                            WriteLine("First Number: ");
                            input1 = ReadLine();
                            WriteLine("Second Number: ");
                            input2 = ReadLine();
                            FirstNumber = ToInt32(input1);
                            SecondNumber = ToInt32(input2);
                            int result = FirstNumber + SecondNumber;
                            WriteLine("Result: " + result + "!");
                            Thread.Sleep(2000);
                            Clear();
                            break;
                        }

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        {

                            Clear();
                            WriteLine("You picked Substraction");
                            WriteLine("First Number: ");
                            input1 = ReadLine();
                            WriteLine("Second Number: ");
                            input2 = ReadLine();
                            FirstNumber = ToInt32(input1);
                            SecondNumber = ToInt32(input2);
                            int result = FirstNumber - SecondNumber;
                            WriteLine("Result: " + result + "!");
                            Thread.Sleep(2000);
                            Clear();
                            break;
                        }

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        {
                            Clear();
                            WriteLine("You picked Multiplication");
                            WriteLine("First Number: ");
                            input1 = ReadLine();
                            WriteLine("Second Number: ");
                            input2 = ReadLine();
                            FirstNumber = ToInt32(input1);
                            SecondNumber = ToInt32(input2);
                            int result = FirstNumber * SecondNumber;
                            WriteLine("Result: " + result + "!");
                            Thread.Sleep(2000);
                            Clear();
                            break;
                        }
                        
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        {
                            Clear();
                            WriteLine("You picked Division");
                            WriteLine("First Number: ");
                            input1 = ReadLine();
                            WriteLine("Second Number: ");
                            input2 = ReadLine();
                            FirstNumber = ToInt32(input1);
                            SecondNumber = ToInt32(input2);
                            int result = FirstNumber / SecondNumber;
                            WriteLine("Result: " + result + "!");
                            Thread.Sleep(2000);
                            Clear();
                            break;
                        }
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        {
                            Clear();
                            WriteLine("You picked Modulus");
                            WriteLine("First Number: ");
                            input1 = ReadLine();
                            WriteLine("Second Number: ");
                            input2 = ReadLine();
                            FirstNumber = ToInt32(input1);
                            SecondNumber = ToInt32(input2);
                            int result = FirstNumber % SecondNumber;
                            WriteLine("Result: " + result + "!");
                            Thread.Sleep(2000);
                            Clear();
                            break;
                        }
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        {
                            Clear();
                            WriteLine("Exit Selected");
                            isRunning = false;
                            break;

                            

                        }
                }
            }
        }
    }
}






