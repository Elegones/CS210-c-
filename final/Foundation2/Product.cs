public class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _amount;


    public Product(string name,string ID,double price,int amount)
    {
        _name=name;
        _id=ID;
        _price=price;
        _amount=amount;

    }


    public double ProductCost()
    {
        return _price*_amount;
    }


    public double GetProductPrice()
    {
        return _price;
    }
   public double GetProductAmount()
    {
        return _amount;
    }
     public string GetProductName()
    {
        return _name;
    }
     public string GetProductID()
    {
        return _id;
    }
}