using System;
using System.Dynamic;

class Referance
{
    private string _book;
    private string _chapter;
    private string _verse;



     public string GetRef()
    {
    return ($"{_book} {_chapter}:{_verse}" );
    }
     public void SetRef(string book,string chapter,string verse)
    {
    _book=book;
    _chapter=chapter;
    _verse=verse;
    }
    
}