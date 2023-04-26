using System;

class Program
{
    static void Main(string[] args)
    {   


        bool again=true;
        while (again==true){

            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            //Console.Write("What is the magic number? ");
            //int number = int.Parse(Console.ReadLine());
            int counter=0;
            int guess=-9851231;
            while (guess != number)
            {   Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                counter=counter+1;
                if(guess>number)
                {
                    Console.Write("Lower\n");
                }
                else if(guess<number)
                {
                    Console.Write("Higher\n");
                }
                else
                {
                    Console.Write("You guessed it!\n");
                }
            }
            Console.Write($"Attempts {counter}\n");
            Console.Write($"You want play again?\n");
            string play_question= Console.ReadLine();
            if (play_question=="yes" || play_question=="Yes" || play_question=="YES" )
            {
                again=true;
            }
            else{
                again=false;
            }
            
        }
    }
}