class  Activity
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

       public Activity (string intro, string outro,int time)
    {
        _intro=intro;
        _outro=outro;
        _time=time;
    }

    public void CountDown()
    {
        while(_time>0)
        {
            Console.WriteLine(_time);
            _time=_time-1;
        }
    }


    public void Animation()
    {
        
    }

        public void DisplayPrompts()
    {
        
    }
}