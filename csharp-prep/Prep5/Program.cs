using System;

class Program
{
    static void Main(string[] args)
    {



        DisplayWelcome();
        string user_name=PromptUserName();
        int number=PromptUserNumber();
        int square=SquareNumber(number);
        DisplayResult(user_name,square);
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write($"Please enter your name: "); 
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write($"Please enter your favorite number: "); 
            int number = int.Parse(Console.ReadLine());
            return number;
        }


        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        static void DisplayResult(string user_name ,int squared_number)
        {
            Console.WriteLine($"{user_name}, the square of your number is {squared_number}"); 
        }
    }
}