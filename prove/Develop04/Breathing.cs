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
        Console.WriteLine("please wait");
        WaitingAnimation(3);
        
        Console.Write("Begin in: ");
        CountDownAnimation(3);
        _time=_time+3;
        Console.Clear();

        while(_time>0)
        {
            if(_time>9)
            {

                Console.WriteLine($"Breathe in for 5 seconds ");
                CountDownAnimation(5);
               
    

                Console.WriteLine($"Breathe out for 5 seconds");
                CountDownAnimation(5);
               
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
                
                
    

                Console.WriteLine($"Breathe out for {nums} seconds");
                CountDownAnimation(nums);
               
            }

            
        }

        DisplayOutro();
        WaitingAnimation(3);
        Console.Clear();
        
       


    }

}