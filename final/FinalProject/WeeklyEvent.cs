public class WeeklyEvent:Event
{
    private int _weeksDuration;
    

    public WeeklyEvent(string eventTitle,string startHour,string endHour,int eventNumberDay,int weeksDuration):base(eventTitle,startHour,endHour,eventNumberDay){
        this._weeksDuration=weeksDuration;
    } 
    public WeeklyEvent(){
    }
 
    public override void GetEventInformation(){
        Console.WriteLine($"Title:{base.GetEventTitle()}");
        Console.WriteLine($"Start/End:{base.GetStartHour()}hs - {base.GetEndHour()}hs");
        Console.WriteLine($"Number Day:{base.GetEventNumberDay()}");
        Console.WriteLine($"Weeks Duration : {this._weeksDuration}");
    }

}