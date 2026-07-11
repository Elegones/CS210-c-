public class Order
{
    private List<Product>_products=new List<Product>();
    private Customer _customer;

    public Order(Customer person)
    {
        _customer=person;
    }

    public void AddItem(Product item)
    {
        _products.Add(item);
    }

    public double TotalPrice()
    {
        Address location=_customer.GetLocation();
        int shipingCost;
        double _totalPrice=0;
        foreach(Product item in _products)
        {
            double price=item.GetProductPrice();
            double amount=item.GetProductAmount();

            _totalPrice += price*amount;
        }
        if(location.Patriate()==true)
        {
             shipingCost=5;
        }
        else
        {
            shipingCost=35;
        }
        _totalPrice+=shipingCost;

        return _totalPrice;
    }

    public string PackingLabel()
    {
        string productName;
        string productID;
        string packingLabel="";
        foreach(Product item in _products)
        {
            productName=item.GetProductName();
            productID=item.GetProductID();

            packingLabel+=$"Item:{productName},Item ID:{productID} \n";
        
        
            
        }
        return packingLabel;
    }

    public string ShipingLabel()
    {
        string customerName=_customer.GetCName();
        Address home;
        home=_customer.GetLocation();
        string street=home.GetStreet();
        string city=home.GetCity();
        string state=home.GetState();
        string country=home.GetCountry();

        string label=$"Customer:{customerName}, Address:{street},{city},{state},{country}";

        return label;



    }
    
}