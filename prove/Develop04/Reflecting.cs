public class Reflecting : Activity
{
     private string promt="";
    

        public Reflecting(string intro, string outro,int time,string topic): base (intro,outro,time,topic) 
    {
         
    }
        public string GivenPrompt()
    {
      
        Random randomGenerator = new Random();
        int Num =  randomGenerator.Next(1,5);
        if(Num==1)
        {
            promt="Think of a time you overcame a challenge";
        }
        if(Num==2)
        {
            promt="Think of a time you helped someone";
        }
         if(Num==3)
        {
            promt="Think about a person you care about";
        }
         if(Num==4)
        {
            promt="Think about the gospel and what it means to you";
        }
         if(Num==5)
        {
            promt="Think about a time where someone helped you";
        }
       
        
       return promt ;
        

    }
    

    public string Giventhought()
    {
        string thought="";
        Random randomGenerator = new Random();
        int Num =  randomGenerator.Next(1,5);
        if(Num==1)
        {
            thought="How did this experiance make you feel?";
        }
        if(Num==2)
        {
            thought="Did this experiance help you improve yourself?";
        }
         if(Num==3)
        {
            thought="How does this affect you?";
        }
         if(Num==4)
        {
            thought="Why did you go through this experiance?";
        }
         if(Num==5)
        {
            thought="If could change this experiance would you?";
        }
       
        
       return thought ;
        

    }


public void ReflectingLoop()
    {

        List <string> thoughts= new List<string>();
        _prompt=GivenPrompt();
       
         DisplayIntro();
         WaitingAnimation();
         DisplayPrompts();
         Console.WriteLine("enter any key when ready to reflect to continue");
         Console.ReadLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);
        DateTime currentTime=startTime;


        while(currentTime<futureTime)
        {
            
            int old=0;
            int complete=0;
            
            
            
            do 
            {
                 
                 
                _prompt=Giventhought();
                
                if(thoughts.Contains(_prompt))
                {
                    old=1;
                }
                else
                {
                    old=0;
                    
                    thoughts.Add(_prompt);
                }

                complete++;
                if(complete>30)
                {
                    _prompt="";
                    old=0;
                }
                

            }while(old>0);

           
            if(_prompt!="")
            {
            Console.WriteLine(_prompt);
            }
            WaitingAnimation();
           

            


            currentTime = DateTime.Now;
        }
        DisplayOutro();
        WaitingAnimation();
        Console.Clear();

    }

}