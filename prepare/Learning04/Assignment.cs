public class Assignment
{
    protected string _studentName = null;
    private string _topic = null;

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    public string GetSummary()
    {
        string temp = $"{_studentName} - {_topic}";
        return temp;
    }
}