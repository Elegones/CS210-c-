public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

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

    
}