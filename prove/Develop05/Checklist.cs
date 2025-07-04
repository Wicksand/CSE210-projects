class Checklist : BaseGoal
{

    private int _taskCount;
    private int _TaskGoal;
    private int _taskReward;
    public Checklist()
    {
        SetType("checklist");
        SetName();
        SetDescription();
        setPoints();

        bool numCheck = true;
        while (numCheck)
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int taskGoal))
            {
                Console.WriteLine("\n--------------------------------------------------------------------\nInvalid input, Please enter a number\n--------------------------------------------------------------------\n");
                numCheck = true;
            }
            else
            {
                SetTaskGoal(taskGoal);
                numCheck = false;
            }
        }
        bool numCheck2 = true;
        while (numCheck2)
        {
            Console.WriteLine("What is the bonus for accomplishing it that many times? ");
            string num = Console.ReadLine();
            if (!int.TryParse(num, out int reward))
            {
                Console.WriteLine("\n--------------------------------------------------------------------\nInvalid input, Please enter a number\n--------------------------------------------------------------------\n");
                numCheck2 = true;
            }
            else
            {
                _taskReward = reward;
                numCheck2 = false;
            }

        }
    }
    public void SetTaskCount(int num)
    {
        
        _taskCount = num;
    }
    public int GetTaskCount()
    {
        return _taskCount;
    }
    public void SetTaskGoal(int num)
    {
        _TaskGoal = num;
    }
    public int GetTaskGoal()
    {
        return _TaskGoal;
    }
    public override int RecordEvent()
    {
        _taskCount++;

        if (_taskCount >= _TaskGoal && !GetStatus())
        {
            SetStatus(true);
            Console.WriteLine($"Congratulations! You have earned {(GetPoints() + _taskReward)} points.");
            return GetPoints() + _taskReward;

        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points.");
            return GetPoints();
        }

    }
    public override string ConvertToTextFile()
    {
        return $"{GetType()}#{GetName()}#{GetDescription()}#{GetPoints()}#{GetStatus()}#{_taskCount}#{_TaskGoal}#{_taskReward}";
    }

    public Checklist(string name, string desc, int point, bool status, int taskCount, int taskGoal, int reward)
    {
        SetGoal(name, desc, point, status);
        SetType("checklist");
         _taskCount = taskCount;
        _TaskGoal = taskGoal;
        _taskReward = reward;
        

    }
}