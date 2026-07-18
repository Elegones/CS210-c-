class Swimming:Activity
{
   private double _laps;
   private string _type;

   public Swimming(string date,double length,double laps):base(date,length)
    {
        _laps=laps;
        _type="Swiming";
    }

    public override double Distance()
    {   
        double dist=((_laps*50)/1000)*.62;
        dist=Math.Round(dist,2);
        return dist;
    }

    public override double speed()
    {
        double distance=Distance();
        double speed=(distance/_length)*60;
        speed=Math.Round(speed,2);
        return speed ;
    }

    public override double Pace()
    {
        double distance=Distance();
        double pace=_length/distance;
        pace=Math.Round(pace,2);
        return pace;
    }

    public override void GetSummary()
    {
        Console.Write($"{_date} ");
        Console.Write($"{_type} ({_length} min)-");
        Console.Write($"completed Laps {_laps}, ");
        Console.Write($"Distance: {Distance()} miles, ");
        Console.Write($"Speed: {speed()} mph, ");
        Console.WriteLine($"Pace: {Pace()}  minutes per miles");

    }
}