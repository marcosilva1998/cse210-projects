using System;

class Program
{
    static void Main(string[] args)
    {
         WritingAssignment  a= new WritingAssignment ("Samuel Bennett","Multiplication","The Causes of World War II");

         Console.WriteLine( a.GetSummary());
         Console.WriteLine( a.GetWritingInformation());
    }
}