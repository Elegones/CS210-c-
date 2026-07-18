class Cycling:Activity
{
   private double _speed;
   private string _type;

   public Cycling(string date,double length,double speed):base(date,length)
    {
        _speed=speed;
        _type="Biking";
    }

    public override double Distance()
    {
        return (_speed*_length)/60;
    }

   public override double Pace()
    {
        return 60/_speed;
    }

       public override void GetSummary()
    {
        Console.WriteLine($"{_type}:");
        Console.WriteLine($"Speed:{_speed} mph");
        Console.WriteLine($"Distance: {Distance()} Miles");
        Console.WriteLine($"Pace:{Pace()} minutes per miles");

    }

}