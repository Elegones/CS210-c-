class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title,string description,string date,string time, Address place,string weather):base(title,description,date,time,place)
    {
        _weather=weather;
        _type="Outdoor Gathering";

    }

}