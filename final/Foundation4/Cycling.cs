class Cycling:Activity
{
   private double _speed;

   public Cycling(string date,double length,double speed):base(date,length)
    {
        _speed=speed;
    }

    public override double Distance()
    {
        return (_speed*_length)/60;
    }

   public override double Pace()
    {
        return 60/_speed;
    }

}