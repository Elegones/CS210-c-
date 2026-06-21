public class Listing : Activity
{


     private string promt="";
    
        public string GivenPrompt()
    {
      
        Random randomGenerator = new Random();
        int Num =  randomGenerator.Next(1,5);
        if(Num==1)
        {
            promt="What did you do today?";
        }
        if(Num==2)
        {
            promt="what books/scriptures did you read this week?";
        }
         if(Num==3)
        {
            promt="What are looking forward to?";
        }
         if(Num==4)
        {
            promt="How are your classes going";
        }
         if(Num==5)
        {
            promt="How has the Lord blessed you this week?";
        }
       
        
       return promt ;
        

    }
     public Listing(string intro, string outro,int time,string topic): base (intro,outro,time,topic) 
    {


    }

    public void ListingLoop()
    {
         DisplayIntro();
         _prompt=GivenPrompt();
         WaitingAnimation();
         Console.Clear();
         Console.WriteLine("Write as many response as you can for the prompt");
         DisplayPrompts();
         
         Console.WriteLine("Begin.");


        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);
        DateTime currentTime=startTime;

        while(currentTime<futureTime)
        {
            Console.Write("-");
            Console.ReadLine();

            currentTime=DateTime.Now;

        }

        DisplayOutro();
        WaitingAnimation();
        Console.Clear();
    }


}