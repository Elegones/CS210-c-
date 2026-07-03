using System;
using System.Drawing;
using System.IO; 

public class Simple:Goal
{
    private bool _completed=false;

     public Simple (string name,string description,int points):base(name,description,points)
    { 
        

    }

       public Simple (string name,string description,int points,bool completed):base(name,description,points)
    { 
        _completed=completed;

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



    public override string SaveGoals()
    {
        return $"Simple^{_completed}^{_name}^{_description}^{_points}";
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