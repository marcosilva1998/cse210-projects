using System.IO; 
public class Files
{
    private string _file_Name="save.txt";
    private List<List<String>> _Lines=new List<List<string>>();
    public Files()
    {
    }

    public List<List<String>> get_Lines()
    {
        return this._Lines;
    }
    public void set_Lines( List<String> lines)
    {
        this._Lines.Add(lines);
    }
    public void Write(int Userpoints)
    {    
        
        using (StreamWriter outputFile = new StreamWriter(_file_Name))
        {   
            outputFile.WriteLine(Userpoints);
            foreach (List<string> line in this._Lines)
            {
                for(int i=0 ; i< line.Count-1;i++){
                    outputFile.Write($"{line[i]},");
                }
                outputFile.Write($"{line[line.Count-1]}");
            
                outputFile.WriteLine();
            }
            
            
        }

    }
    public List<Goal> Read()
    {   
        string[] lines = System.IO.File.ReadAllLines(_file_Name);
        List<Goal> goalsList = new List<Goal>();
        string userPoints = lines[0];

        for (int i = 1; i < lines.Length; i++){

            string line = lines[i]; 
            string[] lineElements = line.Split(',');
            string goalType=lineElements[0].Split(':')[0];
            string goalName=lineElements[0].Split(':')[1];
            string goalDescription=lineElements[1];
            string goalPoints=lineElements[2];
            switch (goalType)
                    {
                        case "SimpleGoal":
                            string goalState=lineElements[3];
                            goalsList.Add(new SimpleGoal(int.Parse(goalPoints),goalDescription,goalName,bool.Parse(goalState)));
                            break;
                        case "EternalGoal":

                            goalsList.Add(new EternalGoal(int.Parse(goalPoints),goalDescription,goalName));
                            break;
                        case "CheckListGoal":
                            string goalActualCounter=lineElements[5];
                            string goalMaxCounter=lineElements[4];
                            string goalEndpoints=lineElements[3];
                            goalsList.Add(new CheckListGoal(int.Parse(goalPoints),goalDescription,goalName,int.Parse(goalActualCounter),int.Parse(goalMaxCounter),int.Parse(goalEndpoints)));
                            break;
                    }

        }

        return goalsList;
    }
    




}