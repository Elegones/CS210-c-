public class Order
{
    private List<Product>_products=new List<Product>();
    private Customer _customer;

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

            packingLabel+=$"{productName},{productID}:";
        
        
            
        }
        return packingLabel;
    }

    public string ShipingLabel()
    {
        string customerName=_customer.GetCName();
        Address home;
        home=_customer.GetLocation();

        string label=$"Customer:{customerName}, Address:{home}";

        return label;



    }
    
}