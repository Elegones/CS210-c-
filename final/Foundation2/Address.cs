public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street,string city,string state,string country)
    {
        _street=street;
        _city=city;
        _state=state;
        _country=country;
    }


    public bool Patriate()
    {
        bool citizen;
        if(_country=="USA")
        {
            citizen=true;
        }
        else
        {
            citizen=false;
        }

        return citizen;

    }

    public void DisplayAddress()
    {
        Console.WriteLine($"Address: {_street},{_city},{_state},{_country}");

    }

    public string GetCountry()
    {
        return _country;
    }
     public string GetStreet()
    {
        return _street;
    }
     public string GetCity()
    {
        return _city;
    }
     public string GetState()
    {
        return _state;
    }
    
}