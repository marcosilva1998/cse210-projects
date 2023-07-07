public class Calendar
{
 private List<Day> _days=new List<Day>();   
 private string _fileName ;
private DateTime _actualDate;
 
 public Calendar(){
    this._actualDate=DateTime.Now;

 }

 public DateTime GetEventDate(){
        return this._actualDate;
 }
 public void AddEvent(){

 }

 public void RemoveEvent(){

 }
 public void GetEventsDay(){
    
 }
 public void GetEventsWeek(){
    
 }
 public void SaveCalendar(){
    
 }
 public void LoadCalendar(){
    
 }

}