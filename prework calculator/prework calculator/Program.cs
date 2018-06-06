using System;

namespace prework_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;

            while (displayMenu)
            {
               displayMenu = CalculatorMenu();
            }
        }
        static bool CalculatorMenu()
        {

            Console.WriteLine("Choose what you want to do.");
            Console.WriteLine("1) ADD + ");
            Console.WriteLine("2) Subtract - ");
            Console.WriteLine("3) Multiply * ");
            Console.WriteLine("4) Divide / ");
            Console.WriteLine("5) Exit");
            string userOptionSelected = Console.ReadLine();


            if (userOptionSelected == "1")
            {
                Console.WriteLine("enter first number.");
                double firstNumToAdd = double.Parse(Console.ReadLine());

                Console.WriteLine("enter your second number and add to first");
                double secondNumToAdd = double.Parse(Console.ReadLine());

                double twoNumsAdded = firstNumToAdd + secondNumToAdd;

                Console.WriteLine($"You added {firstNumToAdd} + {secondNumToAdd} and got {twoNumsAdded}");
                Console.ReadLine();
            }
            else if (userOptionSelected == "2")
            {
                Console.WriteLine("enter first number.");
                double firstNumToSubtract = double.Parse(Console.ReadLine());

                Console.WriteLine("enter your second number and subtract from first");
                double secondNumToSubtract = double.Parse(Console.ReadLine());

                double twoNumsSubtract = firstNumToSubtract - secondNumToSubtract;

                Console.WriteLine($"You subtracted {firstNumToSubtract} - {secondNumToSubtract} and got {twoNumsSubtract}");
                Console.ReadLine();

            }
            else if (userOptionSelected == "3")
            {
                Console.WriteLine("enter first number.");
                double firstNumToMultiply = double.Parse(Console.ReadLine());

                Console.WriteLine("enter your second number and subtract from first");
                double secondNumToMultiply = double.Parse(Console.ReadLine());

                double twoNumsMultiply= firstNumToMultiply * secondNumToMultiply;

                Console.WriteLine($"You multiplied {firstNumToMultiply} * {secondNumToMultiply} and got {twoNumsMultiply}");
                Console.ReadLine();
            }
            else if (userOptionSelected == "4")
            {
                Console.WriteLine("enter first number.");
                double firstNumToDivide = double.Parse(Console.ReadLine());

                Console.WriteLine("enter your second number and subtract from first");
                double secondNumToDivide = double.Parse(Console.ReadLine());

                double twoNumsDivide = firstNumToDivide / secondNumToDivide;

                Console.WriteLine($"You divided {firstNumToDivide} / {secondNumToDivide} and got {twoNumsDivide}");
                Console.ReadLine();
            }
            else if (userOptionSelected == "5")
            {
               
                return false;
            }

            return true;
        }
    }
}
