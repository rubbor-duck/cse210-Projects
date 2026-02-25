public class MathAssignment : Assignment
{
    private double _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, double textbookSelection, string problems) : base(name, topic)
    {
        _textbookSection = textbookSelection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        string temp = $"{GetSummary()}\nSection {_textbookSection} Problems {_problems}";
        return temp;
    }
}