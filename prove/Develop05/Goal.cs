using System.ComponentModel.DataAnnotations;

public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal (string name,string description,int points)
    {
        _name=name;
        _description=description;
        _points=points;

    }

    public virtual void Display()
    {
        
    }

    public virtual void GetSavedGoal()
    {
        
    }

    public virtual void SaveGoals()
    {
        
    }

    public virtual void CompleteGoal()
    {
        
    }



   



}