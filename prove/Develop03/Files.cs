public class Files
{
    private List<List<Word>> _lines = new  List<List<Word>>();
    private  string _file_name="texts.txt";

    private List<Reference> _reference = new List<Reference>() ;
    public Files()
    {
    }
    
    public  void Set_file_name(string x){
        this._file_name=x;

    }

    public List<List<Word>> Get_lines(){

        return this._lines;
    }
     public List<Reference> Get_reference(){

        return this._reference;
    }

    public void Read()
    {   
        string[] lines = System.IO.File.ReadAllLines(this._file_name);

        for (int i = 0; i < lines.Length; i++)
        {   

            
            string[] text =lines[i].Split(' ');

            Reference aux_Reference= new Reference();
            aux_Reference.Set_book(text[0]);
            aux_Reference.Set_chapter(int.Parse(text[1].Split(':')[0]));

            string verse = text[1].Split(':')[1];  
            if(verse.Contains('-'))
            {
                 aux_Reference.Set_verse(int.Parse(verse.Split('-')[0]),int.Parse(verse.Split('-')[1]));
            }
            else
            {
                 aux_Reference.Set_verse(int.Parse(verse));
            }           
            
            this._reference.Add(aux_Reference);


            
            List<string> auxList = new List<string>();

            for (int f =2;f< text.Length;f++){
                auxList.Add(text[f]);
            }

            _lines.Add(new List<Word>());

            foreach (string word in auxList)
            {
                Word auxWord=new Word(); 
                auxWord.Set_word(word);
                _lines[i].Add(auxWord);
            }

            
            
  
        }
    }

    public int Get_length_list(){

        return this._lines.Count;

    }


}