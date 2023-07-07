public abstract class Event
{
    private string _eventType;
  
    private string _evetTitle;

    private string _startHour;
    private string _endHour;

    public Event(string eventType,string eventTitle){
        

    }

    public string GetEventType(){

        return this._eventType;

    }

    public string GetEventTitle(){
        return this._evetTitle;
    }

    public abstract void GenerateEvent();
 


}