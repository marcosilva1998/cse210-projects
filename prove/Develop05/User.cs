public class User
{
    private int _userPoints;
    private List<Goal> _goalList = new List<Goal>();



public User(int userPoints){
    this._userPoints=userPoints;

}

public void DisplayScore(){

}

private string[] BaseQuestions()
{
    string[] valores = new string[3];
    Console.Write("What is the name of your goal ");
    valores[0]=Console.ReadLine();
    Console.Write("What is a short description of it ");
    valores[1]=Console.ReadLine();
    Console.Write("What is the amount of points associated with this goal? ");
    valores[2]=Console.ReadLine();
    return valores;
}

public void CreateSimpleGoal(){
    string[] valores;
    valores=BaseQuestions();

    SimpleGoal simpleGoal = new SimpleGoal(Convert.ToInt32(valores[2]),valores[1],valores[0],false);

    this._goalList.Add(simpleGoal);
}
public void CreateEternalGoal(){
    string[] valores;
    valores=BaseQuestions();
    

    EternalGoal eternalGoal = new EternalGoal(Convert.ToInt32(valores[2]),valores[1],valores[0]);

    this._goalList.Add(eternalGoal);

}
public void CreateCheckListGoal(){
    string[] valores;
    valores=BaseQuestions();
    Console.Write("How many times does this goal need to be accomplished for a bonus ");
    int maxCounter=Convert.ToInt32(Console.ReadLine());
    Console.Write("What is the bonus for accomplishing it that many times? ");
    int endPoints=Convert.ToInt32(Console.ReadLine());
    CheckListGoal checkListGoal = new CheckListGoal(Convert.ToInt32(valores[2]),valores[1],valores[0],0,maxCounter,endPoints);
    this._goalList.Add(checkListGoal);
}
public void RecordEvent(){

}
public void ShowGoalList(){

   for(int i=0 ; i< this._goalList.Count;i++)
        {
            if (this._goalList[i].IsFinished()){
               Console.Write("[X]");
            }
            else{
              Console.Write("[ ]");  
            }
            this._goalList[i].GoalStatus();

            Console.WriteLine();
        }  

    Console.WriteLine($"You have {this._userPoints} points ");
}



public void SaveUserInfo(){
    Files files = new Files();
    for(int i=0 ; i< this._goalList.Count;i++)
    {
        files.set_Lines(this._goalList[i].SaveList());
           
    }  
    files.Write(this._userPoints);   

    
}

public void Load(){
    Files files = new Files();
    this._goalList=files.Read();
}


public void AccomplishGoal(){
    
    Console.Write("Which goal did you accomplish? ");
    int i=Convert.ToInt32(Console.ReadLine());
    if(this._goalList[i-1].IsFinished()){
        Console.WriteLine("The goal is finished, choose other goal");

    }else{
        if (i > _goalList.Count && i <= 0){
            Console.WriteLine("Invalid value");
        }else{
            int points=this._goalList[i-1].DoGoal();
            Console.WriteLine($"Congratulations! you have earned {points} points.");
            this._userPoints=this._userPoints+points;
            Console.WriteLine($"You now have {this._userPoints} points.");
        }  
    }
}

    
}