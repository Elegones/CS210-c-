using System;

class Program
{
    static void Main(string[] args)
    {
        int total=0;
        int max=0;
        
        int listSize=0;
        List<int> numbers= new List<int>();
        string numberIn;
        int math=1;
        Console.WriteLine("Enter a list of numbers and 0 to end it.");
        while(math!=0)
        {
           numberIn = Console.ReadLine();
           math=int.Parse(numberIn);
           numbers.Add(math);
           Console.WriteLine("Enter a number");
        }

        foreach(int num in numbers)
        {
            total= total +num;
            if(max<num)
            {
                max=num;
            }
        }
        listSize= numbers.Count -1;
       decimal ave =(decimal)total/listSize;
        Console.WriteLine($"Sum of numbers is {total}");
        Console.WriteLine($"Largest number is {max}");
        Console.WriteLine($"The list average is  {ave}");
    }
}

