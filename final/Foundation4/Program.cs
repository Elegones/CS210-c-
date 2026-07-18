using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> workout=new List<Activity>();

        Cycling riding =new Cycling("1/1/2027",120,13);
        workout.Add(riding);

        Swimming swim=new Swimming("8/15/2026",60,35);
        workout.Add(swim);

        Running run=new Running("5/13/2026",68,6);
        workout.Add(run);

        foreach(Activity exersize in workout)
        {
            exersize.GetSummary();
            Console.WriteLine();
        }

    }
}