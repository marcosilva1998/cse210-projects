public class Word
{
    private string _word;
    private  Boolean _hide_word;

    public Word()
    {
    }
    
    public void Set_word(string x){
        this._word=x;

    }

    public string Get_word(){
        string x="";
        if (Is_hide_word()){
            for(int i=0 ; i< this._word.Length;i++)
            {
                x= x+"_";
            }  
        }
        else
        {
            x=this._word;
        }
        return x;
    }

    public void Set_hide_word(Boolean x){
        this._hide_word=x;
    }
     public Boolean Is_hide_word(){
        return this._hide_word;
    }


}