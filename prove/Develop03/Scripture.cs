using System;

class Scripture
{
    private Referance _referance;
    private  List<Secrets> _secret = new List<Secrets>();
    private string _verse;
    private bool _condition;
    private int _length;
   private Random randomGenerator = new Random();
    

    private string _scripture;



    

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

     public int GetSBool()
    {int boll=0;
          foreach (Secrets secret in _secret )
            {      
               _condition=secret.GetBool();
                 if(_condition==true)
                 {
                     boll=boll+1;
                 }
            }
      return boll;

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
             int boll=0;
             int secretNum=1;
                foreach (Secrets secret in _secret )
            {      
               _condition=secret.GetBool();
                 if(_condition==true)
                 {
                     boll=boll+1;
                 }

                 secretNum++;

                
            }

             if(boll<3)
                {
                    i=3-boll;
                    
                }

            if(boll==0)
                {
                    i=3;
                }
           
            while(i<3)
        {
          
              


              int x=0;
               int Num=0;
               //
               Num =randomGenerator.Next(1,secretNum);
            
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