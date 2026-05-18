using System;

class Program
{
    static void Main(string[] args)
    {
        double top;
        double bottom;
        double deci;
        string fraction;
        int i=1;
        Fraction frac = new Fraction(5,7);
        fraction=frac.GetFraction();
        deci=frac.GetDecimal();
        top=frac.GetTop();
        bottom=frac.GetBottom();
        Console.WriteLine(deci);
        Console.WriteLine($"fraction: {fraction}, Numerator: {top} , Denomenator: {bottom}");

        Random rand= new Random();
        Fraction tion=new Fraction();
        while(i<= 20)
        {
            top=rand.Next(1,100);
            bottom=rand.Next(1,100);
            tion.SetBottom(bottom);
            tion.SetTop(top);
            fraction=tion.GetFraction();
            deci=tion.GetDecimal();

            Console.WriteLine($"  fraction {i}: {fraction}, Decimal: {deci}");




            i++;
            

        }
       

    }
}