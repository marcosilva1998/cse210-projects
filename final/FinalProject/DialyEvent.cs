public  class DialyEvent:Event
{
 
    private int _daysDuration;
    

    public DialyEvent(string eventTitle,string startHour,string endHour,int eventNumberDay,int daysDuration):base(eventTitle,startHour,endHour,eventNumberDay){
        this._daysDuration=daysDuration;
    }
    public DialyEvent(){

    }

    public override void GetEventInformation(){
        Console.WriteLine($"Title:{base.GetEventTitle()}");
        Console.WriteLine($"Start/End:{base.GetStartHour()}hs - {base.GetEndHour()}hs");
        Console.WriteLine($"Number Day:{base.GetEventNumberDay()}");
        Console.WriteLine($"Days Duration : {this._daysDuration}");

    }

}