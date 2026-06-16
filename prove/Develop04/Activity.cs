public class  Activity
{
   protected string _intro;
   protected string _outro;
   protected int _time;
   protected List<string> _prompts=new List<string>();

   public Activity (string intro, string outro,int time, List<string> prompts)
    {
        _intro=intro;
        _outro=outro;
        _time=time;
        _prompts=prompts;
    }


    

    public Activity (int time)
    {
       
        _time=time;
        
    }

       public Activity (string intro, string outro,int time)
    {
        _intro=intro;
        _outro=outro;
        _time=time;
    }

    public int CountDown()
    {
        if (_time>0)
        {
            _time=_time-1;
            return _time;

        }
        else return 0;
        
    }


    public void CountDownAnimation()
    {   
        
        Console.Write($"Time left:{_time}");
        while(_time!=0)
        {
        

        _time=CountDown();

        Thread.Sleep(500);

        Console.Write("\b \b"); // Erase the + character
        Console.Write($"{_time}"); // Replace it with the - character
        }
    }

        public void DisplayPrompts()
    {
        Console.WriteLine();
    }

        public void DisplayIntro()
    {
        Console.WriteLine(_intro);
    }
        public void DisplayOutro()
    {
        Console.WriteLine(_outro);
    }
}