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
         Console.WriteLine($"Event:{_type}: {_title} \n Summary:{_description},Date:{_date},Time:{_time},Location:{_location},Conditions:{_weather}");
    }

}