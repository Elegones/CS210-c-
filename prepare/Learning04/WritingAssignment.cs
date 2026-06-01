public class WritingAssignment:Assignments
{
    private string _title;
    private string _author;
    
    

    public WritingAssignment(string name,string topic,string title):base(name, topic)
    {
        _title=title;

    }

    public string GetWritingAssignment()
    {
        _author=GetName();
        return "Tittle: "+_title+ "by: "+_author;
    }


}