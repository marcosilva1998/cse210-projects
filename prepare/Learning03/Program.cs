using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction try1 =new Fraction(1);
        Fraction try2 =new Fraction(5);
        Fraction try3 =new Fraction(3,4);
        Fraction try4 =new Fraction(1,3);

        Console.WriteLine( try1.GetFractionString());
        Console.WriteLine( try1.GetDecimalValue());
        
        Console.WriteLine( try2.GetFractionString());
        Console.WriteLine( try2.GetDecimalValue());

        Console.WriteLine( try3.GetFractionString());
        Console.WriteLine( try3.GetDecimalValue());

        Console.WriteLine( try4.GetFractionString());
        Console.WriteLine( try4.GetDecimalValue());



        
        
      

    }
}