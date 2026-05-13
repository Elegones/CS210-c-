using System;
using System.Security.Cryptography.X509Certificates;

class Program
{

      static string GivenPrompt()
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

    static void Main(string[] args)
    {


    

       Journal j1 =new Journal();
       int choice;
       int entryNum=0;
        do
        {
             

            Console.WriteLine("Please enter your choice");
            Console.WriteLine("1:Write");
            Console.WriteLine("2:Display");
            Console.WriteLine("3:Load");
            Console.WriteLine("4:Save");
            Console.WriteLine("5:Exit");

            choice=int.Parse(Console.ReadLine());

            if (choice==1)
            {  
                 entryNum++;
                string words=GivenPrompt();

                Entry entry1=new Entry();

                entry1._entryNum=entryNum;

                 //Console.Write("Please enter the date :");
                //entry1._date=Console.ReadLine();
                DateTime theCurrentTime =DateTime.Now;
                 entry1._date= theCurrentTime.ToShortDateString();
                 Console.WriteLine(words);
                entry1._prompt=words;
                 Console.Write("Please enter your response :");
                entry1._respose=Console.ReadLine();

                j1._entrys.Add(entry1);
               

              
               
            }
            else if(choice==2)
            {
               j1.DisplayJournals(); 
            }
            


            
        }while( choice!=5);
            
            
        
        
    }
}