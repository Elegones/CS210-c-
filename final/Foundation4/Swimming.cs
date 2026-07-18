class Swimming:Activity
{
   private double _laps;

   public Swimming(string date,double length,double laps):base(date,length)
    {
        _laps=laps;
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

}