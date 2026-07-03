using System;
using System.IO; 

 public class Eternal:Goal
{
     
     public Eternal (string name,string description,int points):base(name,description,points)
    { 
        

    }

     public override void Display()
    {
         Console.WriteLine($"{_name} {_description}");
    }

 

    public override string SaveGoals()
    {
        return $"Eternal^{_name}^{_description}^{_points}";
    }
    

    public override int CompleteGoal()
    {
       return _points;

    }

}