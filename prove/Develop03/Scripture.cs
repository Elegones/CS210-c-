using System;

class Scripture
{
    private Referance _referance;
    private  List<Secrets> _secret = new List<Secrets>();
    private string _verse;
    private bool _condition;
    private int _length;
    Random randomGenerator = new Random();
    

    private string _scripture;

    //private Referance _referance = new Referance();

    

    public void SetScripRef(Referance reff)
    {
        _referance=reff;
    }

        public void SetVerse(string verse)
    {
        _verse=verse;
    }
    


   public void SSS()
    {
        int w=0;
       string[] _words= _verse.Split(" ");
       foreach (string word in _words)
        {
            Secrets sect =new Secrets();
            sect.SetSecrets(word);
            _secret.Add(sect); 
       
            w++;
          
            
        }

    }

    


    public  void DisplayScripture()
    {
        _scripture=_referance.GetRef();
        Console.WriteLine($"{_scripture} {_verse}");

        

    }

    public void DisplaySec()
    { 
        
        _length=_verse.Length;
        int i=0;
     
       
        
      
        string displayText="";
            while(i<3)
        {
              int x=0;
               int Num=0;
               //
               Num =randomGenerator.Next(1,31);
            
            foreach (Secrets secret in _secret )
            {   
            x++;
                
            

            
            
               
                if (Num ==x)
                    {
                        _condition=secret.GetBool();
                       if(_condition==true)
                        {
                            i=i+1;
                        }
                        secret.HideWord();
                        
                    }
                

            
            

                
                


            }
        }

       foreach (Secrets secret in _secret )
        {      
         

            

             displayText += " " +secret.GetSecrets();

             


             
        }
            Console.WriteLine(_scripture);
            Console.WriteLine(displayText);
    }



    
}