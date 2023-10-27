using System;

namespace CalculatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Write(@"Hello, welcome to the calculator program!
            Please enter a number: ");
                int userInput1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("\n            Please enter another number: ");
                int userInput2 = Convert.ToInt32(Console.ReadLine());

                Console.Write(@"What type of operation would you like to do?
            Please enter:
            A for addition
            S for subtraction
            M for multiplication
            D for division");

                string operation = Console.ReadLine().ToUpper();
                int result = 0;
                switch (operation)
                {
                    case "A":
                        result = userInput1 + userInput2;
                        Console.WriteLine(userInput1 + " + " + userInput2 + " = " + result);
                        break;
                    case "S":
                        result = userInput1 - userInput2;
                        Console.WriteLine(userInput1 + " - " + userInput2 + " = " + result);
                        break;
                    case "M":
                        result = userInput1 * userInput2;
                        Console.WriteLine(userInput1 + " * " + userInput2 + " = " + result);
                        break;
                    case "D":
                        result = userInput1 / userInput2;
                        Console.WriteLine(userInput1 + " / " + userInput2 + " = " + result);
                        break;
                    default:
                        Console.WriteLine("Invaild operation entered.");
                        break;
                }

                Console.WriteLine(@"Thankyou for using the calculator program!
                                Do you want to continue using the calculator?
                                ");
                string response = Console.ReadLine().ToUpper();
                if (response == "NO")
                {
                    keepRunning = false;
                }
            }

          
         
            }
        }
	

	}
    



