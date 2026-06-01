public class MathAssignment : Assignments
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name,string topic,string section,string problems):base( name, topic)
    {
      _textbookSection=section;
      _problems=problems;
    }

   
    public string GetHomeworkList()
    {
        return "Chapter: "+ _textbookSection+ " Questions: "+ _problems;
    }

}