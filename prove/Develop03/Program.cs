using System;

class Program
{
    static void Main(string[] args)
    {
        string cont="";    
        Files file = new Files();
        file.Read();

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, file.Get_length_list());

        Reference reference = new Reference();

        Scriptures scripture = new Scriptures();

        scripture.Set_scripture(file.Get_lines()[number]);
        reference=file.Get_reference()[number];


        scripture.Clear_display();
        reference.Show_reference();
        scripture.Show_Scripture();

        Console.WriteLine("Press enter to continue or type 'quit' to finish : ");
        cont=Console.ReadLine();  


        while(cont!="quit" && !(scripture.All_hidden())){

            scripture.Clear_display();
            scripture.Hide_words();
            reference.Show_reference();
            scripture.Show_Scripture();
            Console.WriteLine("Press enter to continue or type 'quit' to finish : ");
            cont=Console.ReadLine();


        }
        
    }
}
//My program work with a library of scriptures rather than a single one. Choose scriptures at random to present to the user.
//Can load scriptures from a files.