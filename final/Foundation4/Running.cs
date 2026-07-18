class Running:Activity
{
   private double _distance;
   private string _type;

   public Running(string date,double length,double distance):base(date,length)
    {
        _distance=distance;
        _type="Running";
    }


    public override double speed()
    {
        return (_distance/_length)*60;
    }

   public override double Pace()
    {
        double speeds= speed();
        return 60/speeds;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{_type}:");
        Console.WriteLine($"Speed: {speed()} mph");
        Console.WriteLine($"Distance: {_distance}  Miles");
        Console.WriteLine($"Pace: {Pace()} minutes per miles");

    }


}