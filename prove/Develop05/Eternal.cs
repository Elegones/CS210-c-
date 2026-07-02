

 public class Eternal:Goal
{
     
     public Eternal (string name,string description,int points):base(name,description,points)
    { 
        

    }

     public override void Display()
    {
         Console.WriteLine($"{_name} {_description}");
    }

     public override void GetSavedGoal()
    {
        
    }

    public override void SaveGoals()
    {
        
    }

    public override int CompleteGoal()
    {
       return _points;

    }

}