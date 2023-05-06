public class Journal
{
    private List <string> _prompts_List= new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    private Random _rd;
    private List <string> _new_entries= new List<string>();
    private DateTime _aDate;

    public Files file=new Files();
    public Journal()
    {
    }
    public void Write()
    {
        this._rd= new Random();
        int rand_num = _rd.Next(4);
        string prompt=this._prompts_List[rand_num];
        Console.WriteLine(prompt);
        string new_imput = Console.ReadLine();
        this._aDate= DateTime.Now;
        string date_now=_aDate.ToString("MM/dd/yyyy");
        this._new_entries.Add($"Date: {date_now} - Prompt:{prompt}\n{new_imput}");
    }
    public void Display()
    {

        foreach (string entrie in _new_entries)
        {   
            Console.WriteLine($"{entrie} ");
        }
    }
    public void Load()
    { 
        Console.WriteLine($"Please enter the file name ");
        this.file.set_file_Name(Console.ReadLine());
        this._new_entries.Clear();
        this.file.Read();
        this._new_entries= this.file.get_Lines();
  
    }
    public void Save()
    {   
        Console.WriteLine($"Please enter the file name ");
        this.file.set_file_Name(Console.ReadLine());
 
        this.file.set_Lines(_new_entries);
        this.file.Write();
    }


}