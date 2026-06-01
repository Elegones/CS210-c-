public class Assignments
{
    private string _studentName;
    private string _topic;

public Assignments(string name,string topic)
    {
        _studentName=name;
        _topic=topic;
        
    }
    public Assignments()
    {
        _studentName="unknown";
        _topic="unknown";
        
    }
    public string Getsummary()
    {
        
        return "Name: "+ _studentName+"  Topic: "+_topic;
    }

    public string GetName()
    {
        
        return  _studentName;
    }
    


}