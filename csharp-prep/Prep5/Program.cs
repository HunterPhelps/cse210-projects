using System;

class Program
{
    static void Main(string[] args)
    {
        void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program.");
        }
        string PromptUserName()
        {
            Console.Write("What is your name? ");
            string username = Console.ReadLine();
            return username;
        }
        int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int usernumber = int.Parse(Console.ReadLine());
            return usernumber;
        }
        int SquareNumber(int usernumber)
        {
            int squarednumber = usernumber * usernumber;
            return squarednumber;
        }
        void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name} your number squared is {number}.");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squarednumber = SquareNumber(number);
        DisplayResult(name, squarednumber);
    }
}