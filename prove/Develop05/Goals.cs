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
    public void SaveGoals()
    {
        GetFileName();
        using (StreamWriter writer = new StreamWriter(_filename))
        {
            writer.WriteLine(_pointsTotal);
            foreach (BaseGoal goal in goals)
            {
                writer.WriteLine(goal.ConvertToTextFile());
            }
            
        }
    }
    public void LoadGoals()
    {
        GetFileName();
        if (!File.Exists(_filename))
        {
            Console.WriteLine("\n--------------------------------------------------------------------\nFile not found\n--------------------------------------------------------------------\n");
            return;
        }
        else
        {
            string[] lines = File.ReadAllLines(_filename);
            goals.Clear();

            if (int.TryParse(lines[0], out int points))
            {
                _pointsTotal = points;
            }
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('#');
                string type = parts[0];

                switch (type)
                {
                    case "simple":
                        SimpleGoal loadsimp = new SimpleGoal(parts[1],parts[2],int.Parse(parts[3]),bool.Parse(parts[4]));
                        goals.Add(loadsimp);
                        break;
                    case "eternal":
                        EternalGoal loadete = new EternalGoal(parts[1],parts[2],int.Parse(parts[3]),bool.Parse(parts[4]));
                        goals.Add(loadete);
                        break;
                    case "checklist":
                        Checklist loadcheck = new Checklist(parts[1],parts[2],int.Parse(parts[3]),bool.Parse(parts[4]),int.Parse(parts[5]),int.Parse(parts[6]),int.Parse(parts[7]));
                        goals.Add(loadcheck);
                        break;
                    default:
                        Console.WriteLine("\n--------------------------------------------------------------------\nType not found\n--------------------------------------------------------------------\n");
                        break;
                }
            }
        }

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
        Console.Write("Which goal did you accomplish? ");
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