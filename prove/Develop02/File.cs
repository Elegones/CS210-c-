using System;
using System.IO;
 

public class File()
{
  public string _fileName;
  public Journal _journal = new Journal();

  

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



 



 public Journal LoadingFile()
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        List<string> parts= new List<string>();

        foreach (string line in lines)
        {
            
            parts.Add(line);
            
            if (parts.Count == 4)
            {
              Entry _fentry=new Entry();
                
                _fentry._entryNum = int.Parse(parts[0]);
                _fentry._date = parts[1];
                _fentry._prompt = parts[2];
                _fentry._respose = parts[3];

                
                _journal._entrys.Add(_fentry);
                parts.Clear();
            }
            
        }

        return _journal;
    }




}




