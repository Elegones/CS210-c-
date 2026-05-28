using System;

class Secrets
{
    private string _words;
    private bool _under=true;

    public string GetSecrets()
    {
        return _words;

    }
    
     public void SetSecrets(string words)
    {
        _words=words;

    }
    

}