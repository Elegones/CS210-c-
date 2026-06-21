public class  Activity
{
   protected string _intro;
   protected string _topic;
   protected string _outro;
   protected int _time;
   protected string _prompt;
   protected int _timeUse;
   
   

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
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);
        DateTime currentTime;

        do
        {
            Console.Write("-");

            Thread.Sleep(200);

             Console.Write("\b \b"); // Erase the + character
            Console.Write("\\"); // Replace it with the - character
            Thread.Sleep(200);

            Console.Write("\b \b"); // Erase the + character
            Console.Write("|"); // Replace it with the - character
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b \b"); // Replace it with the - character?
             currentTime = DateTime.Now;
        }while(currentTime<futureTime);

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