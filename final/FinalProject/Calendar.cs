using Newtonsoft.Json;


public class Calendar
{
 private List<Day> _days=new List<Day>();   
 private string _fileName="calendar.json" ;

 private Boolean _seted=false;
 
 private string _firstDayName;
 private int _calendarDays;

 private string _monthName;
 private int _actualDay;
 
 public List<Day> Days
 {
    get { return this._days; }
    set { this._days = value; }
 }
 public string FileName
 {
    get { return this._fileName; }
    set { this._fileName = value; }
 } 
 public bool Seted
 {
    get { return this._seted; }
    set { this._seted = value; }
 } 
 public string FirstDayName
 {
    get { return this._firstDayName; }
    set { this._firstDayName = value; }
 } 
 public int CalendarDays
 {
    get { return this._calendarDays; }
    set { this._calendarDays = value; }
 } 
 public string MonthName
 {
    get { return this._monthName; }
    set {this._monthName = value; }
 } 
 public int ActualDay
 {
    get { return this._actualDay; }
    set { this._actualDay = value; }
 }
 
 public Calendar(){

 }



public void SetMonthName(string monthName){

  this._monthName=monthName;

}

public void SetMonthFirstDayName(string FDayName){
  this._firstDayName=FDayName;
}
public void SetCalendarDays(int calendarDays){

  List<string> daysOfWeek = new List<string>(){"Sun", "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat"};
  int indexFirstDayName = daysOfWeek.IndexOf(this._firstDayName);

  this._calendarDays=calendarDays;

  
  for (int i = 0; i < this._calendarDays; i+=1)
  {      
      Day day=new Day();
      day.SetDay(daysOfWeek[indexFirstDayName]);
      this._days.Add(day);

      if (indexFirstDayName==6){
        indexFirstDayName=0;
      }
      else
      {
        indexFirstDayName=indexFirstDayName+1;
      }
      
  }

}

public void SetActualDay(int actualDay){
   this._actualDay=actualDay;
}
private string[] BaseQuestions()
{
    string[] values = new string[4];
    Console.Write("What is the title of your event? ");
    values[0]=Console.ReadLine();
    Console.Write("What is the start hour? EXAMPLE 00:00 ");
    values[1]=Console.ReadLine();
    Console.Write("What is the end hour? 18:30 ");
    values[2]=Console.ReadLine();
    Console.Write("What is the number day in that the event will be?  ");
    values[3]=Console.ReadLine();
    return values;
}


 public void AddSimpleEvent(){
   string[] values;
   values=BaseQuestions();
   SimpleEvent simpleEvent = new SimpleEvent(values[0],values[1],values[2],Convert.ToInt32(values[3])-1);

   this._days[Convert.ToInt32(values[3])-1].AddEvent(simpleEvent);

 }
 public void AddDialyEvent(){
   string[] values;
   values=BaseQuestions();
   Console.Write("How many days will repeat it? ");
   int days=Convert.ToInt32(Console.ReadLine());

   
   for (int i = 0; i < days; i+=1)
   {
    DialyEvent dialyEvent = new  DialyEvent(values[0],values[1],values[2],Convert.ToInt32(values[3])-1+i,days);
    this._days[Convert.ToInt32(values[3])-1+i].AddEvent(dialyEvent);
   }

 }
 public void AddWeeklyEvent(){
   string[] values;
   values=BaseQuestions();
   Console.Write("How many weeks will repeat it? ");
   int weeks=Convert.ToInt32(Console.ReadLine());
   
   int counts=0;
   int days=0;
   while (counts<weeks )
   {
    WeeklyEvent weeklyEvent = new  WeeklyEvent(values[0],values[1],values[2],Convert.ToInt32(values[3])-1+days,weeks);
    this._days[Convert.ToInt32(values[3])-1+days].AddEvent(weeklyEvent);
    counts++;
    days=days+7;
   }

 }

 public bool GetSeted(){
  return this._seted;
 }

 public void SetSeted(){
   this._seted=true;
 }

 public void GetDayInfo(int day){

  
  foreach (Event ev in this._days[day-1].GetDayEvents()){
    ev.GetEventInformation();
  }
  

 }
  public void GetToDayInfo(){

  
  foreach (Event ev in this._days[this._actualDay-1].GetDayEvents()){
    ev.GetEventInformation();
  }
  

 }

 public void RemoveEvent(int day,string tittle){
  int i=0;
  foreach (Event ev in this._days[day-1].GetDayEvents()){

     if(ev.GetEventTitle()==tittle)
     {
       this._days[day-1].DeleteEvent(i);
       break;
     }
     i++;
  }

 }
 public void GetEventsDay(){
    
 }
 public void GetEventsWeek(){
    
 }
 public void SaveCalendar()
 {
    string jsonString = JsonConvert.SerializeObject(this, Formatting.Indented);
    File.WriteAllText(this._fileName, jsonString);
    Console.WriteLine("Calendar saved successfully.");
}
 public void LoadCalendar(){
  string jsonString = File.ReadAllText("calendar.json");
  Calendar calendar = JsonConvert.DeserializeObject<Calendar>(jsonString);

  this._days = calendar.Days;
  this._seted = calendar.Seted;
  this._firstDayName = calendar.FirstDayName;
  this._calendarDays = calendar.CalendarDays;
  this._monthName = calendar.MonthName;
  this._actualDay = calendar.ActualDay;

  Console.WriteLine("JSON data loaded successfully.");
    
 }

}