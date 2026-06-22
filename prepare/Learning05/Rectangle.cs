using System.Reflection.Metadata.Ecma335;

public class Rectangle:Shape
{
    private double _side;
    private double _base;
    public Rectangle(string color, double side,double basse):base(color)
    {
        _side=side;
        _base=basse;

    }

    public override double GetArea()
    {
       double area=_side*_base;

        return area;

    }


}