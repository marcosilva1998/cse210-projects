using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.\n");
        int number;
        int counter =0;
        List<int> numbers = new List<int>();


        Console.Write("Enter number: ");
        number = int.Parse(Console.ReadLine());
        while (number != 0)
        {
            numbers.Add(number);
            counter=counter+1;

            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

        }
        int sum=0;
        int max=-999999;
        int min=999999;
        foreach (int num in numbers)
        {
            sum=sum+num;
            if(num > max){
                max=num;
            }

            if(num >0 && num < min)
            {
                min=num;
            }
        }
        float average=sum/counter;

        Console.Write($"The sum is: {sum} \n");
        Console.Write($"The average is: {average} \n");
        Console.Write($"The largest number is: {max} \n");





        Console.Write($"The smallest positive number is: {min}\n");
        numbers.Sort();
        
        Console.Write($"The sorted list is:\n");
        foreach (int num in numbers)
        {
            Console.Write($"{num}\n");
        }

    }
}