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
        Console.WriteLine($" Event:{_type} ,Title:{_title},Date:{_date}");
    }

    public void DisplayStandard()
    {
         Console.WriteLine($"{_title}\n Summary of Event:{_description}\n will take place on:{_date} at:{_time} \n Location:{_location}");
    }


}