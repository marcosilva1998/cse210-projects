public abstract class Goal
{

    private int _points;
    private string _description;
    private string _name;


    public Goal(int points,string description,string name){
        this._points=points;
        this._description=description;
        this._name=name;
        
    }
    
    


    public string GetName(){
        return this._name;
    }
    public string GetDescription(){
        return this._description;
    }
    public int GetPoints(){
        return this._points;
    }

    public abstract void GoalStatus();


    public abstract string TypeGoal();

    public abstract List<string>SaveList();

    public abstract Boolean IsFinished();

    public abstract int DoGoal();



}