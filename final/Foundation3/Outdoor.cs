class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title,string description,string date,string time, Address place,string weather):base(title,description,date,time,place)
    {
        _weather=weather;
        _type="Outdoor Gathering";

    }

    public void DisplayFullOutdoorGathering()
    {
         Console.WriteLine($"Event:{_type}: {_title} \n Summary of {_type}: {_description}\nDate:{_date},Time:{_time}\n Conditions: it will be {_weather}");
         DisplayAddress();
         Console.WriteLine();
    }

}