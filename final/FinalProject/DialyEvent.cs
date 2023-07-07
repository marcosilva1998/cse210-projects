public abstract class DialyEvent:Event
{
 
private int _daysDuration;
    

    public DialyEvent(string eventType,string eventTitle,int daysDuration):base(eventType,eventTitle){
        this._daysDuration=daysDuration;
    }

     public override void GenerateEvent(){

     }

}