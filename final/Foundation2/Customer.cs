public class Customer
{
    private string _cName;
    private Address _location;

    public Customer(string name, Address location)
    {
        _cName=name;
        _location=location;
    }



    public bool Citizen()
    {
       return _location.Patriate();
       

    }
    public Address GetLocation()
    {
        return _location;
    }

    public string GetCName()
    {
        return _cName;
    }

 
    
}