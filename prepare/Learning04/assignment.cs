class Assignment
{

    private string _studentName = "";
    private string _topic = "";

    public Assignment()
    {
        _studentName = "studentName";
        _topic = "unknown topic";
    }

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string GetStudent()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
  

}