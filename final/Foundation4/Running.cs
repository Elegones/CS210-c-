class Running:Activity
{
   private double _distance;

   public Running(string date,double length,double distance):base(date,length)
    {
        _distance=distance;
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


}