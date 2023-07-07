using System;

class Program
{
   static void Main(string[] args)
    {
        string choosed;
        string choosed2;
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Event");
        Console.WriteLine("  2. ");
        Console.WriteLine("  3. Save Events");
        Console.WriteLine("  4. Load Events");
        Console.WriteLine("  5. Quit");
        Console.Write("Select a choice from the menu: ");
        choosed= Console.ReadLine();

        while (choosed != "6"){

            switch (choosed)
            {
                case "1":
                    Console.WriteLine("The types of Events are");
                    Console.WriteLine("  1. Simple Event");
                    Console.WriteLine("  2. Dialy Event");
                    Console.WriteLine("  3. Weekly Event");
                    choosed2= Console.ReadLine();
                    
                    switch (choosed2)
                    {
                        case "1":

                            break;
                        case "2":

                            break;
                        case "3":

                            break;
                    }

                    break;
                case "2":

                    break;
                case "3":

                    break;
                case "4":
                    break;
                default:
                    break;


                
            }
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Event");
            Console.WriteLine("  2. ");
            Console.WriteLine("  3. Save Events");
            Console.WriteLine("  4. Load Events");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            choosed= Console.ReadLine();
        }
    }
}