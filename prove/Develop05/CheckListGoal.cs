public class CheckListGoal:Goal
{
    private int _actualCounter;
    private int _maxCounter;
    private int _endPoints;



public CheckListGoal(int points,string description,string name,int actualCounter,int maxCounter,int endPoints):base(points,description,name){
    this._actualCounter=actualCounter;
    this._maxCounter=maxCounter;
    this._endPoints=endPoints;
    

}
public override void GoalStatus(){
    Console.Write($" {base.GetName()} ({base.GetDescription()}) --Currently completed : {this.GetActualCounter()}/{this.GetMaxCounter()}");
}
public override string TypeGoal(){
    return "CheckListGoal";
}


public int GetActualCounter(){
    return this._actualCounter;

}
public int GetMaxCounter(){
    return this._maxCounter;
    
}

public override Boolean IsFinished(){
    return  this._maxCounter<= this._actualCounter;
}


public override List<string> SaveList(){
    List<string> line = new List<string>();  
    line.Add($"{this.TypeGoal()}:{this.GetName()}");
    line.Add(base.GetDescription());
    line.Add(base.GetPoints().ToString());
    line.Add(this._endPoints.ToString());
    line.Add(this._maxCounter.ToString());
    line.Add(this._actualCounter.ToString());
    return  line;
}
public override int DoGoal(){
    int points=0;
    this._actualCounter=this._actualCounter+1;
    if (this._actualCounter==this._maxCounter){
        points = this._endPoints+base.GetPoints();
    }else{
        points=base.GetPoints();
    }
    return points;
}
    
}