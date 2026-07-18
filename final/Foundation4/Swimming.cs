class Swimming:Activity
{
   private double _laps;
   private string _type;

   public Swimming(string date,double length,double laps):base(date,length)
    {
        _laps=laps;
        _type="swiming";
    }

    public override double Distance()
    {
        return ((_laps*50)/1000)*.62;
    }

    public override double speed()
    {
        double distance=Distance();
        return (distance/_length)*60;
    }

    public override double Pace()
    {
        double distance=Distance();
        return _length/distance;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{_type}:");
        Console.WriteLine($"Laps {_laps} completed");
        Console.WriteLine($"Speed: {speed()} mph");
        Console.WriteLine($"Distance: {Distance()} Miles");
        Console.WriteLine($"Pace: {Pace()}  minutes per miles");

    }
}