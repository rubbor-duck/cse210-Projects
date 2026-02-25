public class WritingAssignment : Assignment
{
    private string _title = null;

    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string temp = $"{GetSummary()}\n{_title} by {_studentName}";
        return temp;
    }
}