class Cycling:Activity
{
   private double _speed;
   private string _type;

   public Cycling(string date,double length,double speed):base(date,length)
    {
        _speed=speed;
        _type="Cycling";
    }

    public override double Distance()
    {   double dist=(_speed*_length)/60;
        dist=Math.Round(dist,2);
        return dist;
    }

   public override double Pace()
    {
        double pace=60/_speed;
        pace=Math.Round(pace,2);
        return pace;
    }

       public override void GetSummary()
    {
        Console.Write($"{_date} ");
        Console.Write($"{_type} ({_length} min)");
        Console.Write($"-Distance: {Distance()} miles,");
        Console.Write($" Speed:{_speed} mph, ");
        Console.WriteLine($"Pace:{Pace()} minutes per miles");

    }

}