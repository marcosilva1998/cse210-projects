using System;

class Program
{
    static void Main(string[] args)
    {   
        

        
        int n;
        Journal new_journal= new Journal();
        Console.WriteLine("Welcome to the Journal Program¡");
        do
        {  
        Console.WriteLine();
        Console.WriteLine("Please select on of the following choices");
        Console.WriteLine("1.Write");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Quit");
        n=int.Parse( Console.ReadLine());
        Console.WriteLine();
        if(n == 1)
        {
            new_journal.Write();
        }
        else if (n==2)
        {
            new_journal.Display();
        }
        else if (n==3)
        {
            new_journal.Load();
        }
        else if (n==4)
        {
            new_journal.Save();
        }
        }while(n != 5);
    }
}