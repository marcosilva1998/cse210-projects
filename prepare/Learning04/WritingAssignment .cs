public class WritingAssignment :Assignment
{
    private string _title;


    public WritingAssignment (string studentName,string topic,string _title):base(studentName,topic){
        this._title=_title;
    }
    public string GetWritingInformation(){

        return $"{this._title} by {base.GetStudentName()}";
    }
    
};