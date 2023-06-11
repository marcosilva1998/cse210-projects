using System;

class Program
{
    static void Main(string[] args)
    {
        string choosed;
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        choosed= Console.ReadLine();
        switch (choosed)
        {
            case "1":
                Breathing breathing= new Breathing();
                breathing.Starting_message();
                breathing.Start_activity();
                breathing.Ending_message();
                break;
            case "2":
                Reflection reflection= new Reflection();
                reflection.Starting_message();
                reflection.Start_activity();
                reflection.Ending_message();
                break;
            case "3":
                Listing listing =new Listing();
                listing.Starting_message();
                listing.Start_activity();
                listing.Ending_message();
                break;
            case "4":
                break;
            default:
                break;
        }


    }
    //Make sure no random prompts/questions are selected until they have all been used at least once in that session.
}