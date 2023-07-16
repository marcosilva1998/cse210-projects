using Newtonsoft.Json.Linq;
public class Day
{

 private List<Event>_events=new List<Event>();

 private string _dayName;



 public List<Event> Events
 {
    get { return this._events; }
    set { this._events = value; }
 }


public string DayName
{
    get { return this._dayName; }
    set { this._dayName = value; }
}
 public Day(){
    
 }

 public void AddEvent(Event x){
    this._events.Add(x);
 }

 public void SetDay(string day){
   this._dayName=day;
 }

 public List<Event> GetDayEvents(){
   return this._events;
 }

 public void DeleteEvent( int x){

  this._events.RemoveAt(x);
  
  
 }


}