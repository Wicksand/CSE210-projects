using System.Data;
using System.Runtime.CompilerServices;

class Goals
{
    private string _filename;
    private List<BaseGoal> goals = new List<BaseGoal>();

    public Goals()
    {

    }
    public void DisplayGoals()
    {
        int count = 1;
        foreach (BaseGoal goal in goals)
        {
            string check;
            if (goal.GetStatus())
            {
                check = "[x]";
            }
            else
            {
                check = "[ ]";
            }

            Console.WriteLine($"{count}. {check} {goal.SetGoal()}");
            count++;
        }
    }
    public void LoadGoals()
    {

    }
    public void AddGoal(BaseGoal goal)
    {
        goals.Add(goal);
    }
    public void RecordGoalEvent()
    {
        DisplayGoals();
        Console.WriteLine("Wich Goal did you accomplish? ");
        string read = Console.ReadLine();


        if (int.TryParse(read, out int count) && count > 0 && count <= goals.Count)
        {
            goals[count - 1].RecordEvent();
        }
        else
        {
            Console.WriteLine("There are no goals with that value.");
        }
    }
    private void GetFileName()
    {
        Console.WriteLine("What is the filenamefor the goal file? ");
        _filename = Console.ReadLine();
    }
}