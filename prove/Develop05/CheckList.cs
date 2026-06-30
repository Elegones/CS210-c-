using System.ComponentModel.DataAnnotations;

public class CheckList:Goal
{
    private int _total;
    private int _count=0;
    private int _bonus;
     public CheckList (string name,string description,int points,int total,int bonus):base(name,description,points)
    { 
        _total=total;
        _bonus=bonus;

    }

     public override void Display()
    {
        string conditon;
        if(_count>=_total)
        {
            conditon="[x]";
        }
        else
        {
            conditon=$"[{_count}/{_total}]";
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
        _count++;
        if(_count<_total)
        {
            return _points;

        }
        else if(_count==_total)
        {
            return _points+_bonus;
        }
        else
        {
            return 0;
        }
       
    }

}