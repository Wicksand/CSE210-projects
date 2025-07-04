using System.Data;
using System.Numerics;
using System.Runtime.CompilerServices;

class Goals
{
    private string _filename;
    private List<BaseGoal> goals = new List<BaseGoal>();

     private int _pointsTotal = 0;

    public Goals()
    {

    }
    public void DisplayGoals()
    {
        int count = 1;
        Console.WriteLine();
        foreach (BaseGoal goal in goals)
        {
            string check;
            string end;
            if (goal.GetStatus())
            {
                check = "[x]";
            }
            else
            {
                check = "[ ]";
            }

            if (goal is Checklist checklist)
            {
                end = $" -- Currently completed: {checklist.GetTaskCount()}/{checklist.GetTaskGoal()}";
            }
            else
            {
                end = "";
            }

            Console.WriteLine($"{count}. {check} {goal.GetName()} ({goal.GetDescription()}){end}");
            count++;
        }
    }
    public void LoadGoals()
    {

    }
        public void AddPointsTotal(int num)
    {
        _pointsTotal += num;
    }
    public int GetPointsTotal()
    {
        return _pointsTotal;
    }

    public void AddGoal(BaseGoal goal)
    {
        goals.Add(goal);
    }
    public void RecordGoalEvent()
    {
        DisplayGoals();
        Console.Write("Wich Goal did you accomplish? ");
        string read = Console.ReadLine();


        if (int.TryParse(read, out int count) && count > 0 && count <= goals.Count)
        {
            // goals[count - 1].RecordEvent();
            // AddPointsTotal(goals.RecordEvent());
            BaseGoal goal = goals[count - 1];
            AddPointsTotal(goal.RecordEvent());
            Console.WriteLine($"You now have {GetPointsTotal()} points.");
        }
        else
        {
            Console.WriteLine("There are no goals with that value.");
        }
    }
    private void GetFileName()
    {
        Console.Write("What is the file name for the goal file? ");
        _filename = Console.ReadLine();
    }
}