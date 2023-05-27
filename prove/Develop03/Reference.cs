public class Reference
{
    private string _book;
    private  int _chapter;

    private List<int> _verse = new List<int>();

    public Reference()
    {
    }
    

    public string Get_book(){
        return this._book;
    }
    public void Set_book(string x){
        this._book=x;
    }
    public int Get_chapter(){
        return this._chapter;
    }

    public void Set_chapter(int x){
        this._chapter=x;
    }

    public List<int> Get_verse(){
        return this._verse;
    }

     
    public void Set_verse(int x){
        this._verse.Add(x);

    }
     
     
    public void Set_verse(int x ,int y){
            this._verse.Add(x);
            this._verse.Add(y);
        
        

    }

    public string Get_string_reference(){
        string verse_str="";
        if (this._verse.Count >1)
        {
             verse_str=this._verse[0].ToString()+"-"+this._verse[this._verse.Count-1];
        }
        else
        {
            verse_str=this._verse[0].ToString();
        }
        
        string str=this._book+" "+this._chapter.ToString()+":"+verse_str;
        return str;
    }

    public void Show_reference(){
        Console.Write(Get_string_reference()+" ");
    }


}