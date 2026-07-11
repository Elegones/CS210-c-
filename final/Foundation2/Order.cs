public class Order
{
    private List<Product>_products=new List<Product>();
    private Customer _customer;

    public double TotalPrice()
    {
        int shipingCost;
        double _totalPrice=0;
        foreach(Product item in _products)
        {
            double price=item.GetProductPrice();
            double amount=item.GetProductAmount();

            _totalPrice += price*amount;
        }
        if(Customer._location.Patriate()==true)
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
    
}