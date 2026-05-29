using System;

class Program 
{
    static void Main(string[] args)
    {
        string verse="And it came to pass that he taught it so much that many did believe on his words, even so many that they began to support him and give him money";
        int unhidden=1;
        Scripture script =new Scripture();
        Referance reff =new Referance();
        //Secrets verse =new Secrets();
        Secrets sect =new Secrets();


        

       reff.SetRef("Alma","1","5");

     //  string france= reff.GetRef();
       
       //Console.WriteLine(france);

      script.SetVerse(verse);
      script.SetScripRef(reff);
      script.DisplayScripture();
      script.SSS();
      while(unhidden!=0)
      {
        
       
        string enter=Console.ReadLine();


       
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