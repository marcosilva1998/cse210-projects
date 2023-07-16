using System;

class Program
{
   static void Main(string[] args)
    {
        string choosed;
        string choosed2;
        
        Calendar calendar= new Calendar();
        Console.WriteLine("Menu Options:");
        if(calendar.GetSeted()==false){
            Console.WriteLine(" PLEASE SET MONTH OR LOAD FROM FILE");
        }
        Console.WriteLine("  1. Create New Event");
        Console.WriteLine("  2. Set Month ");
        Console.WriteLine("  3. Save in file");
        Console.WriteLine("  4. Load form file");
        Console.WriteLine("  5. Event in a day info");
        Console.WriteLine("  6. Event  today info");
        Console.WriteLine("  7. Remove Event");
        Console.WriteLine("  8. Quit");
        Console.Write("Select a choice from the menu: ");
        choosed= Console.ReadLine();

        while (choosed != "8"){

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
                            
                            calendar.AddSimpleEvent();

                            break;
                        case "2":
                            calendar.AddDialyEvent();
                            break;
                        case "3":
                            calendar.AddWeeklyEvent();
                            break;
                    }

                    break;
                case "2": 
                    Console.WriteLine("Type the month name (Jan Feb Mar Apr May Jun Jul Aug Sep Oct Nov Dec) ");
                    string month_name= Console.ReadLine();
                    Console.WriteLine("Type the first month day name (Sun Mon Tues Wed Thurs Fri Sat) ");
                    string first_day_name= Console.ReadLine();
                    Console.WriteLine("Ingress the numbers of days in month ");
                    string month_days_num= Console.ReadLine();
                    Console.WriteLine("Ingress the actual day number ");
                    string actual_day_num= Console.ReadLine();

                    
                    
                    calendar.SetMonthName(month_name);
                    calendar.SetMonthFirstDayName(first_day_name);
                    calendar.SetCalendarDays(Convert.ToInt32(month_days_num));
                    calendar.SetActualDay(Convert.ToInt32(actual_day_num));
                    calendar.SetSeted();



                    break;
                case "3":
                    calendar.SaveCalendar();

                    break;
                case "4":
                    calendar.LoadCalendar();
                    break;
                case "5":
                    Console.WriteLine("Ingress the number of the day you want see events");
                    int search_day_num= Convert.ToInt32(Console.ReadLine());
                    calendar.GetDayInfo(search_day_num);

                    break;
                case "6":
                    calendar.GetToDayInfo();

                    break;
                case "7":
                    Console.WriteLine("Ingress the number of the day you want remove a event");
                    int remove_day_num= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is the title of your event? ");
                    string title=Console.ReadLine();   
                    calendar.RemoveEvent(remove_day_num,title);

                    break;
                default:
                    break;


                
            }
            Console.WriteLine("Menu Options:");
            if(calendar.GetSeted()==false)
            {
                Console.WriteLine(" PLEASE SET MONTH OR LOAD FROM FILE");
            }
            Console.WriteLine("  1. Create New Event");
            Console.WriteLine("  2. Set Month ");
            Console.WriteLine("  3. Save in file");
            Console.WriteLine("  4. Load form file");
            Console.WriteLine("  5. Event in a day info");
            Console.WriteLine("  6. Event  today info");
            Console.WriteLine("  7. Remove Event");
            Console.WriteLine("  8. Quit");
            Console.Write("Select a choice from the menu: ");
            choosed= Console.ReadLine();
        }
    }
}