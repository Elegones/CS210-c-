public class Breathing : Activity
{
    private int num=0;
    private int nums=0;

public Breathing(string intro, string outro,int time,string topic): base (intro,outro,time,topic) 
{
        


}

public void BreathingLoop()
    {
        
        DisplayIntro();
        Console.Write("please wait");
        WaitingAnimation();
        Console.Clear();

        while(_time>0)
        {
            if(_time>9)
            {

                Console.WriteLine($"Breathe in for 5 seconds ");
                CountDownAnimation(5);
                Console.WriteLine();
    

                Console.WriteLine($"Breathe out for 5 seconds");
                CountDownAnimation(5);
                Console.WriteLine();
            }

             else 
            {
                num=_time/2;
                nums=num;
                if(num*2!=_time)
                {
                    nums=num+1;
                }
                
                Console.WriteLine($"Breathe in for {num} seconds ");
                CountDownAnimation(num);
                Console.WriteLine();
                
    

                Console.WriteLine($"Breathe out for {nums} seconds");
                CountDownAnimation(nums);
                Console.WriteLine();
            }

            
        }

        DisplayOutro();
        WaitingAnimation();
        Console.Clear();
        
       


    }

}