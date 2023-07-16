public class SimpleEvent:Event
{   
    public SimpleEvent(string eventTitle,string startHour,string endHour,int eventNumberDay):base(eventTitle,startHour,endHour,eventNumberDay){
        
    }
    public SimpleEvent(){
        
    }
    
    public override void GetEventInformation(){
         Console.WriteLine($"Title:{base.GetEventTitle()}");
         Console.WriteLine($"Start/End:{base.GetStartHour()}hs - {base.GetEndHour()}hs");
         Console.WriteLine($"Number Day:{base.GetEventNumberDay()}");

        
    }



}