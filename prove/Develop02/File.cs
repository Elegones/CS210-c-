using System;
using System.IO;
 

public class File()
{
  public string _fileName;
  public Journal _journal;

    public void SavingFile()
    {
    using (StreamWriter OutputFile=new StreamWriter(_fileName) )
    {
        
   
        foreach(Entry entry in _journal._entrys)
        {
        
           OutputFile.WriteLine(entry._entryNum);
           OutputFile.WriteLine(entry._date);
           OutputFile.WriteLine(entry._prompt);
           OutputFile.WriteLine(entry._respose);
        
        }

  }
}

}