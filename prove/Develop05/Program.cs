using System;

class Program
{
    static void Main(string[] args)
    {
        string choosed;
        string choosed2;
        User user = new User(0);
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from the menu: ");
        choosed= Console.ReadLine();

        while (choosed != "6"){

            switch (choosed)
            {
                case "1":
                    Console.WriteLine("The types of Goals are");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create ");
                    choosed2= Console.ReadLine();
                    
                    switch (choosed2)
                    {
                        case "1":
                            user.CreateSimpleGoal();
                            break;
                        case "2":
                            user.CreateEternalGoal();
                            break;
                        case "3":
                            user.CreateCheckListGoal();
                            break;
                    }

                    break;
                case "2":
                    user.ShowGoalList();
                    break;
                case "3":
                    user.SaveUserInfo();
                    break;
                case "4":
                    user.Load();
                    break;
                case "5":
                    user.AccomplishGoal();
                    break;
                default:
                    break;


                
            }
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choosed= Console.ReadLine();
        }
    }
}