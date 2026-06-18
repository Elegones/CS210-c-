public class Reflecting : Activity
{
    
    public string GivenPrompt()
    {
        string promt="";
        Random randomGenerator = new Random();
        int Num =  randomGenerator.Next(1,5);
        if(Num==1)
        {
            promt="Which country should become the 51 sate";
        }
        if(Num==2)
        {
            promt="How much of our GDP should go to the millitary";
        }
         if(Num==3)
        {
            promt="Should we invade the ocean";
        }
         if(Num==4)
        {
            promt="Was the moon landing real";
        }
         if(Num==5)
        {
            promt="How did today go";
        }
       
        
       return promt ;
        

    }
    
    public Reflecting(string intro, string outro,int time,string topic): base (intro,outro,time,topic) 
{
         


}

public void ReflectingLoop()
    {
        _prompt=GivenPrompt();
         DisplayIntro();
         DisplayPrompts();
         Console.ReadLine();


    }

}