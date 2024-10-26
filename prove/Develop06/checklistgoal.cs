using System.Drawing;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name,string description,int points,int target, int bonus=0) 
    :base(name,description,points)
    {
        _target = target;
        _amountCompleted = 0;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine($"{_shortName} progress: {_amountCompleted}/{_target} completed");

            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Congratulations! You completed the checklist and earned a bonus of {_bonus} points!");
                _points += _bonus;
            }
        }
         else
        {
            Console.WriteLine($"{_shortName} is already fully completed.");
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailString()
    {
         return $"[ ] {_shortName} ({_description}) Currently Completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
    return $"ChecklistGoal:{_shortName},{_description},{_points},{_target},{_bonus}";
}
    
}