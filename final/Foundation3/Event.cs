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
        Console.WriteLine($" Event:{_type}: {_title}, Date:{_date}");
        Console.WriteLine();
    }

    public void DisplayStandard()
    {
        

         Console.WriteLine($"{_title}\n Summary of {_type}:{_description}\n will take place on:{_date} at:{_time} ");
         DisplayAddress();
         Console.WriteLine();
    }

    public void DisplayAddress()
    {
        string city=_location.GetCity();
        string country=_location.GetCountry();
        string state=_location.GetState();
        string street=_location.GetStreet();

        Console.WriteLine($" Address: {street}, {city}, {state}, {country}");
         
    }


}