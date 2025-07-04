using System.Dynamic;

class Goal
{
    public Goal()
    {

    }

    public int GetPoints()
    {
        bool numCheck = true;
        int points = 0;
        while (numCheck)
        {
            Console.Write("What is the amount of points associated with this goal?");
            string testpoint = Console.ReadLine();

            if (!int.TryParse(testpoint, out points))
            {
                Console.WriteLine("\n--------------------------------------------------------------------\nInvalid input, Please enter a number\n--------------------------------------------------------------------\n");
                numCheck = true;
            }
            else
            {
                numCheck = false;
            }
        }
        return points;
    }
}