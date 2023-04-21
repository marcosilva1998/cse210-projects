using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade_percentage = Console.ReadLine();
        int grade_percentage_int=int.Parse(grade_percentage);
        string letter="";
        if( grade_percentage_int >= 90)
        {
            letter="A";
        }
        else if (grade_percentage_int >= 80)
        {
            letter="B";
        }
        else if (grade_percentage_int >= 70)
        {
            letter="C";
        }
        else if (grade_percentage_int >= 60)
        {
            letter="D";
        }
        else{
            letter="F";
        }

        string sign="";
        int unit=grade_percentage_int % 10;
        if (letter!= "F" && grade_percentage_int != 100)
        {
            if(unit>=7 && letter!= "A")
            {
            sign="+";
            }
            else if(unit>=3)
            {
            sign="";
            }
            else
            {
            sign="-";
            }
        }
        Console.Write($"{letter} {sign}\n");

        if (letter =="A" ||letter =="B" || letter =="C"  )
        {
            Console.Write("Congratulations you passed¡");
        }
        else{
            Console.Write("You did not pass ,better luck the next time :c");
        }

    }
}