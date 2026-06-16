public class Breathing : Activity
{
    

public Breathing(string intro, string outro,int time): base (intro,outro,time) 
{
        


}

public void BreathingLoop()
    {
        Console.WriteLine($"Welcome to the breathing activity");
        DisplayIntro();

        Console.WriteLine($"Breathe in for {_time} seconds ");
        CountDownAnimation();

        Console.WriteLine($"Breathe out for {_time} seconds");
        CountDownAnimation();

        DisplayOutro();


    }

}