public class Breathing : Activity
{
    

public Breathing(string intro, string outro,int time,string topic): base (intro,outro,time,topic) 
{
        


}

public void BreathingLoop()
    {
        
        DisplayIntro();

        Console.WriteLine($"Breathe in for {_time} seconds ");
        CountDownAnimation();
         Console.WriteLine();
    

        Console.WriteLine($"Breathe out for {_timeUse} seconds");
        CountDownAnimation();
        Console.WriteLine();

        DisplayOutro();


    }

}