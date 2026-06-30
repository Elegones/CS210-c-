using System.ComponentModel.DataAnnotations;

public class Simple:Goal
{
    private bool _completed=false;

     public Simple (string name,string description,int points):base(name,description,points)
    { 
        

    }

     public override void Display()
    {
        string conditon;
        if(_completed==true)
        {
            conditon="[x]";
        }
        else
        {
            conditon="[ ]";
        }
        Console.WriteLine($"{conditon} {_name} {_description}");
    }

     public override void GetSavedGoal()
    {
        
    }

    public override void SaveGoals()
    {
        
    }

    public override int CompleteGoal()
    {
        if(_completed==false)
        {
           _completed=true;
           return _points;

        }
        else
        {
            Console.WriteLine("you have already completed this goal");
        return 0;
        }
    }

}