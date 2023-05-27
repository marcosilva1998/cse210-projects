public class Scriptures
{
    private List<Word> _scripture= new List<Word>();


    private List<int> hided_words=new List<int>();
    public Scriptures()
    {
    }
    
    public void Clear_display(){
        Console.Clear();
    }
  
    public Boolean All_hidden(){
        Boolean all =false ;
        for(int i =0 ;i < _scripture.Count;i++){
            if(_scripture[i].Is_hide_word()){
                all=true;
            }else{
                all=false;
                break;
            }
        }
        return all;
    }


    public List<Word>  Get_scripture(){
        return this._scripture;
    }

    public void  Set_scripture(List<Word> x){
        this._scripture=x;

    }

    public void Show_Scripture(){
        for(int i =0;i<this._scripture.Count;i++){
            Console.Write(this._scripture[i].Get_word()+" ");
            

        }
        Console.WriteLine();
    }

    public void Hide_words(){
        Random randomGenerator = new Random();
        int aux;
        if ((this._scripture.Count %2)==0 )
        {
            aux=2;
        }
        else if((this._scripture.Count %3)==0)
        {
            aux=3;
        }
        else
        {
            aux=1;
        }

        for(int i =0 ;i<aux;i++){
            int number = randomGenerator.Next(0, this._scripture.Count);
            while (hided_words.Contains(number)){
                number = randomGenerator.Next(0, this._scripture.Count);
            }
            this._scripture[number].Set_hide_word(true);
            hided_words.Add(number);
            

        }
        
        

    }

    



}