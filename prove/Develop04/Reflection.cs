public class Reflection:Activity
{      private List<String> _prompt_list = new List<string>()        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

     private List<String> _question_list = new List<string>()        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    private List<int>_aviable_prompts= new List<int>(){0,1,2,3};
    private List<int>_aviable_questions= new List<int>(){0,1,2,3,4,5,6,7,8};

    public Reflection():base("Reflection","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."){


    }


    public void Show_prompt(){
    }
     
    public void Show_question(){
    }

    public void Start_activity(){

        Random random = new Random();
        int prompt_number = random.Next(0, this._aviable_prompts.Count);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"---  {this._prompt_list[prompt_number]}  ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.Read();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");

        base.Pausing_contdown(3);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(this.Get_duration());



        while (DateTime.Now<endTime)
        {
            int question_number = random.Next(0, this._aviable_questions.Count);
            Console.Write(this._question_list[this._aviable_questions[question_number]]);
            Pausing_spinner(10);
            Console.WriteLine();
            

            this._aviable_questions.Remove(this._aviable_questions[question_number]);
    

            if (this._aviable_questions.Count==0){
                this._aviable_questions=new List<int>{0,1,2,3,4,5,6,7,8};

            }
        }

        



        
        


    }
    
    
};