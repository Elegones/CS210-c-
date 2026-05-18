using System;
using System.Reflection.Metadata.Ecma335;

class Fraction
{
  private double _top;
  private double _bottom;

 public Fraction ()
    {
        _top=1;
        _bottom=1;

    }

    public Fraction (double top)
    {
        _top=top;
        _bottom=1;

    }

    

  public Fraction (double top, double bottom)
    {
        _top=top;
        _bottom=bottom;

    }
    public string GetFraction()
    {
    return ($"{_top}/{_bottom}" );
    }
    public double GetDecimal()
    {
        
        return _top/_bottom;
    }
    public double GetTop()
    {
        return _top;
    }
      public double GetBottom()
    {
        return _bottom;
    }
    public void SetTop(double top)
    {
        _top=top;
        
    }

     public void SetBottom(double bottom)
    {
        _bottom=bottom;
        
    }
}