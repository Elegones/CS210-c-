using System;

class Program 
{
    static void Main(string[] args)
    {
        string verse="And it came to pass that he taught it so much that many did believe on his words, even so many that they began to support him and give him money";

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
     


       //verse.SetSecrets("And it came to pass that he taught it so much that many did believe on his words, even so many that they began to support him and give him money");

       
    }
}