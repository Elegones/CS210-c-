using System;

class Secrets
{
    private string _words;
    private bool _under=true;

    

    public string GetSecrets()
    {
        if (_under)
        return _words;
        else 
        return new string('_',_words.Length);

    }

     public bool GetBool()
    {
      return _under;

    }
    
     public void SetSecrets(string words)
    {
        _words=words;

    }
    public void HideWord()
    {
        _under=false;

    }

}