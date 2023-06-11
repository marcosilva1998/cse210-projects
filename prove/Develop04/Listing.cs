public class Listing:Activity
{   
    private List<String> _prompt_list = new List<string>()        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

    private int _items_entered=0;


    public Listing():base("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."){
        

    }



    public void Start_activity(){


        base.Pausing_spinner(7);
        Random random = new Random();
        int prompt_number = random.Next(0, this._prompt_list.Count);


        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"---  {this._prompt_list[prompt_number]}  ---");
        base.Pausing_contdown(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(this.Get_duration());



        while (DateTime.Now<endTime)
        {
            string aux=Console.ReadLine();

            if(DateTime.Now<endTime){
                this._items_entered=this._items_entered+1;
            }
            else{
                Console.WriteLine("The last was out of the time :c ");
            }
    
        }

        Console.WriteLine($"You listed {this._items_entered} items");



    }
 
    
};