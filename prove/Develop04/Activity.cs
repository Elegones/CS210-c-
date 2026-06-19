public class  Activity
{
   protected string _intro;
   protected string _topic;
   protected string _outro;
   protected int _time;
   protected string _prompt;
   protected int _timeUse;
   
   

 


    

    public Activity (int time)
    {
       
        _time=time;
        _timeUse=_time;
        
    }

       public Activity (string intro, string outro,int time,string topic)
    {
        _intro=intro;
        _outro=outro;
         _time=time;
        _timeUse=_time;
        _topic=topic;
    }

    public int CountDown(int time)
    {
        
        if (time>0)
        {
            time=time-1;
            return time;

        }
        else return 0;
        
    }

    public void CountDownAnimation(int cycle)
    {   
        int i=5;
        //_time =_timeUse;
        Console.Write($"");
        Console.Write(cycle);
        while(cycle!=0 && i>0)
        {
            i=i-1;

            
            
            
        

            _time=CountDown(_time);
            cycle=CountDown(cycle);


            Thread.Sleep(1000);

           
            Console.Write("\b \b"); // Erase the + character
                
            


        
            Console.Write($"{cycle}"); // Replace it with the - character
        }
    }


    public void WaitingAnimation()
    {   
        _time =_timeUse;
        Console.Write($"Time left:{_time}");
        while(_time!=0)
        {
        

        _time=CountDown(_time);

        Thread.Sleep(1000);

        Console.Write("\b \b"); // Erase the + character
        Console.Write($"{_time}"); // Replace it with the - character
        }
    }

        public void DisplayPrompts()
    {
        Console.WriteLine(_prompt);
    }

        public void DisplayIntro()
    {
        Console.WriteLine($"Welcome to the {_topic} activity{_intro}");
    }
        public void DisplayOutro()
    {
        Console.WriteLine($"{_outro} {_topic} activity");
    }
}