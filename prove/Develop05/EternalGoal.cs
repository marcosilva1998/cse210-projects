public class EternalGoal:Goal
{




public EternalGoal(int points,string description,string name):base(points,description,name){

}
public override void GoalStatus(){
    Console.Write($" {base.GetName()} ({base.GetDescription()})");
}
public override string TypeGoal(){
    return "EternalGoal";
}
public override List<string> SaveList(){
    List<string> line = new List<string>();    
    line.Add($"{this.TypeGoal()}:{this.GetName()}");
    line.Add(base.GetDescription());
    line.Add(base.GetPoints().ToString());
    return  line;
}
public override Boolean IsFinished(){
    return false;
}

public override int DoGoal(){
    
    return base.GetPoints();
}
    
}