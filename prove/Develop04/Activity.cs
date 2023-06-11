public class Activity
{
    private int _duration;
    private string _activityname;
    private string _description;

    public Activity(string _activityname,string _description){
        
        this._activityname=_activityname;
        this._description=_description;
        

    }
    public void Starting_message(){
        Console.Clear();
        Console.WriteLine($"Welcome to {this._activityname} Activity.");
        Console.WriteLine();
        Console.WriteLine($"{this._description}");
        Console.WriteLine();

        Console.WriteLine("How long, in seconds, would you like for your session?");
        this._duration=int.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("Get ready...");


    }
    public void Ending_message(){
        Console.WriteLine("Well Done!!");
        Console.WriteLine();
        this.Pausing_spinner(4);
        Console.WriteLine($"You have completed another {this._duration} seconds of {this._activityname} Activity");





        
    }
    public void Pausing_spinner(int sec){
        
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(sec);

        int i =0;

        while (DateTime.Now<endTime)
        {
            string s=animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count){
                i=0;
            }
        }


            
    }

    public void Pausing_contdown(int seconds){
        for(int i = seconds;i>0;i--){
            Console.Write($"You may begin in : {i}");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        }
        Console.WriteLine($"You may begin in :  ");
        
    }

    public int Get_duration(){
        
        return this._duration;
    }

    
};