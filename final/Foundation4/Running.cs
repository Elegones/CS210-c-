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
        double speed=(_distance/_length)*60;
        speed=Math.Round(speed,2);
        return speed ;
    }

   public override double Pace()
    {
        double speeds= speed();
        double pace=60/speeds;
        pace=Math.Round(pace,2);
        return pace;
    }

    public override void GetSummary()
    {   
        Console.Write($"{_date} ");
        Console.Write($"{_type} ({_length} min)-");
        Console.Write($"Distance: {_distance} miles, ");
        Console.Write($"Speed: {speed()} mph, ");
        Console.WriteLine($"Pace: {Pace()} minutes per miles");

    }


}