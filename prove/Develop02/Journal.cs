public class Journal()
{
   

    public List<Entry> _entrys= new List<Entry>();

    public void DisplayJournals()
    {
       
        foreach(Entry entry in _entrys)
        {
            entry.Display();
        }

    }


}