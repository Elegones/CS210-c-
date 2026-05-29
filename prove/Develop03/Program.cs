using System;

class Program 
{
    static void Main(string[] args)
    {  
       string verse="";
       string chapter="";
       string book="";
       string verseNum="";
       Random randomGenerator = new Random();
        int Num =  randomGenerator.Next(1,4);
        if(Num==1)
        {
            book="Alma";
            chapter="1";
            verseNum="5";
            verse="And it came to pass that he taught it so much that many did believe on his words, even so many that they began to support him and give him money";

        }
        if(Num==2)
        {   
            book="D&C";
            chapter="6";
            verseNum="36";
            verse="Look unto me in every thought; doubt not, fear not.";
        }
         if(Num==3)
        {
            book="James";
            chapter="1";
            verseNum="5";
            verse="If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.";
        }
         if(Num==4)
        {
            book="1 Nephi";
            chapter="3";
            verseNum="7";
           
            verse="And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        }
      





       // string verse="And it came to pass that he taught it so much that many did believe on his words, even so many that they began to support him and give him money";
        int unhidden=1;
        Scripture script =new Scripture();
        Referance reff =new Referance();
        
        Secrets sect =new Secrets();


        

       reff.SetRef(book,chapter,verseNum);

     //  string france= reff.GetRef();
       
       //Console.WriteLine(france);

      script.SetVerse(verse);
      script.SetScripRef(reff);
       Console.WriteLine("To hide words hit enter, to exit type exit.");
        script.DisplayScripture();
      
      script.SSS();
      while(unhidden!=0)
      {
       

       
        string enter=Console.ReadLine();
        Console.Clear();


       
      if(enter=="")
      {
       
        script.DisplaySec();

        
      }
      if(enter=="exit")
      {
       
        unhidden=0;

        
      }
      unhidden=script.GetSBool();
      
     
      }

       //verse.SetSecrets("And it came to pass that he taught it so much that many did believe on his words, even so many that they began to support him and give him money");

       
    }
}