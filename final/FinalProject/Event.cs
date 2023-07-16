public abstract class Event
{
 
  
    private string _eventTitle;

    private string _startHour;
    private string _endHour;

    private int _eventNumberDay;

    public string EventTitle
    {
        get { return this._eventTitle; }
        set { this._eventTitle = value; }
    } 
    public string StartHour
    {
        get { return this._startHour; }
        set { this._startHour = value; }
    } 

    public string EndHour
    {
        get { return this._endHour; }
        set { this._endHour = value; }
    } 
    public int EventNumberDay
    {
        get { return this._eventNumberDay; }
        set { this._eventNumberDay = value; }
    } 
    public Event(){
        
    }
    public Event(string eventTitle,string startHour,string endHour,int eventNumberDay){
        this._eventTitle=eventTitle;
        this._startHour=startHour;
        this._endHour=endHour;
        this._eventNumberDay=eventNumberDay;

    }

  
    public string GetEventTitle(){
        return this._eventTitle;
    }

    public string GetStartHour(){
        return this._startHour;
    }
    public string GetEndHour(){
        return this._endHour;
    }
    public int GetEventNumberDay(){
        return this._eventNumberDay+1;
    }



    public abstract void GetEventInformation();
 


}