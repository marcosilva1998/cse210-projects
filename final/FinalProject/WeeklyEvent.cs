public class WeeklyEvent:Event
{
    private int _weeksDuration;
    

    public WeeklyEvent(string eventType,string eventTitle,int weeksDuration):base(eventType,eventTitle){
        this._weeksDuration=weeksDuration;
    }
 
    public override void GenerateEvent(){
        
    }

}