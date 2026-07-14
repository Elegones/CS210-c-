class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _location;
    protected string _type;

    public Event(string title,string description,string date,string time, Address place)
    {
        _title=title;
        _description=description;
        _date=date;
        _time=time;
        _location=place;

    }

    public void DisplayShort()
    {
        Console.WriteLine($"{_type},{_title},{_date}");
    }

    public void DisplayStandard()
    {
         Console.WriteLine($"{_title},{_description},{_date},{_time},{_location}");
    }


}