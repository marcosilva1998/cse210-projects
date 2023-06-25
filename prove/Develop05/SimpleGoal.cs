public class SimpleGoal:Goal
{
    
    private Boolean _complete;


public SimpleGoal(int points,string description,string name,Boolean complete):base(points,description,name){
   this._complete=complete;

}
public override void GoalStatus(){
    Console.Write($" {base.GetName()} ({base.GetDescription()})");
}

public override string TypeGoal(){
    return "SimpleGoal";
}
public override List<string> SaveList(){
    List<string> line = new List<string>();    
    line.Add($"{this.TypeGoal()}:{this.GetName()}");
    line.Add(base.GetDescription());
    line.Add(base.GetPoints().ToString());
    line.Add(this._complete.ToString());
    return  line;
}

public override Boolean IsFinished(){
    return this._complete;
}

public override int DoGoal(){
    this._complete=true;
    

    return base.GetPoints();
}
    
}