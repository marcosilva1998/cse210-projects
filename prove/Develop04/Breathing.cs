public class Breathing:Activity
{


    public Breathing():base("Breathing","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."){
    
    }

    public void Start_activity(){
        base.Pausing_spinner(7);
        
        int duration =base.Get_duration();
        int times=duration/10;
        int remanents=duration%10;


        
        Console.WriteLine();
        if(remanents>0){
            double x =remanents*0.6;
            double y =remanents*0.4;
            for(int l = Convert.ToInt32(x);l>0;l--){
                Console.Write($"Breathe in...{l}");
                Thread.Sleep(1000);
                Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            }
            Console.WriteLine("Breathe in...   ");
            for(int j = Convert.ToInt32(y);j>0;j--){
                Console.Write($"Now breathe out...{j}");
                Thread.Sleep(1000);
                Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            }
            Console.WriteLine("Now breathe out...   ");
            Console.WriteLine();
        }

        for(int o=0;o<times;o++){
            for(int p =6;p>0;p--){
                Console.Write($"Breathe in...{p}");
                Thread.Sleep(1000);
                Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            }
            Console.WriteLine("Breathe in...   ");
            for(int q =4;q>0;q--){
                Console.Write($"Now breathe out...{q}");
                Thread.Sleep(1000);
                Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            }
            Console.WriteLine("Now breathe out...   ");
            Console.WriteLine();
        }
    

    }
    
};