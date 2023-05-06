using System.IO; 
public class Files
{
    private string _file_Name;
    private List<String> _Lines=new List<string>();
    public Files()
    {
    }
    public void set_file_Name(String file_name)
    {
                this._file_Name = file_name;
    }
    public List<String> get_Lines()
    {
        return this._Lines;
    }
    public void set_Lines( List<String> lines)
    {
        this._Lines=lines;
    }
    public void Write()
    {    
        
        using (StreamWriter outputFile = new StreamWriter(_file_Name))
        {
            foreach (string line in this._Lines)
            {
                outputFile.WriteLine(line);
            }
            
        }

    }
    public void Read()
    {   
        string[] lines = System.IO.File.ReadAllLines(_file_Name);

        for (int i = 0; i < lines.Length; i+=2)
        {
            
            this._Lines.Add($"{lines[i]} \n{lines[i+1]}");
        }
    }
    




}