using System;

class Program
{
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

                Entry entry1=new Entry();
                 Console.Write("Please enter the date :");
                entry1._date=Console.ReadLine();

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