public class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _amount;


    public double GetProductPrice()
    {
        return _price;
    }
   public double GetProductAmount()
    {
        return _amount;
    }
}