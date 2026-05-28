using System;

class Scripture
{
    private Referance _referance;
    private  List<Secrets> _secret = new List<Secrets>();
    private string _verse;

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
       string[] _words= _verse.Split(" ");
       foreach (string word in _words)
        {
             Secrets sect =new Secrets();
            sect.SetSecrets(word);
            
            _secret.Add(sect); 
       
            
          
            
        }

    }

    public  void DisplayScripture()
    {
        _scripture=_referance.GetRef();
        Console.WriteLine($"{_scripture} {_verse}");

    }



    
}