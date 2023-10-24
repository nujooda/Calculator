using System;

namespace CalculatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"Hello, welcome to the calculator program!
            Please enter a number: ");
            int userInput1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter another number: ");
            int userInput2 = Convert.ToInt32(Console.ReadLine());

            Console.Write(@"What type of operation would you like to do?
            Please enter:
            A for addition
            S for subtraction
            M for multiplication
            D for division");

            string operation = Console.ReadLine();
            int result = 0;
            switch (operation)
             { 
                  case "A":
                    result = userInput1 + userInput2;
                break;
              }
        }
    }

}

