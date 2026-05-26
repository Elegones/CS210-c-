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
}