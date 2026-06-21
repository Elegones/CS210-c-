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
            promt="Think of a time where you were dealing with a trial";
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
            thought="How did this experiance  affect you?";
        }
         if(Num==4)
        {
            thought="Why do you think you  went through this experiance?";
        }
         if(Num==5)
        {
            thought="If you could change this experiance would you?";
        }
       
        
       return thought ;
        

    }


public void ReflectingLoop()
    {

        List <string> thoughts= new List<string>();
        _prompt=GivenPrompt();
       
         DisplayIntro();
         WaitingAnimation(3);
         DisplayPrompts();
         Console.WriteLine("enter any key when ready to reflect ");
         Console.ReadLine();
         Console.Write("Begin in: ");
         CountDownAnimation(3);
        

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
            WaitingAnimation(_time/4);
           

            


            currentTime = DateTime.Now;
        }
        DisplayOutro();
        WaitingAnimation(3);
        Console.Clear();

    }

}