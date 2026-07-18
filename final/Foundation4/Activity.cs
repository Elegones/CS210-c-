class Activity
{
   protected string _date;
   protected double _length;
   

  public Activity(string date,double length)
    {
        _date=date;
        _length=length;

    }

   public virtual double Distance()
    {
        return 0;
    }

    public virtual double speed()
    {
        return 0;
    }

   public virtual double Pace()
    {
        return 0;
    }



}