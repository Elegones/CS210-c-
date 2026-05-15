using System;
using System.IO;
public class Journal()
{
   
    public string _fileName;
    public List<Entry> _entrys= new List<Entry>();

    public void DisplayJournals()
    {
       
        foreach(Entry entry in _entrys)
        {
            entry.Display();
        }

    }

    public void ClearJ()
    {
        _entrys.Clear();

    }
    
     public int jLength()
    {
       
        return _entrys.Count();

    }
    

}