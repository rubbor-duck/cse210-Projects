using System.Reflection.PortableExecutable;

public abstract class Goals
{
    private string _name;
    private string _description;
    private int _points;
    protected bool _complete;

    public Goals(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = false;
    }

    public virtual void RecordEvent()
    {
        _complete = true;
    }

    public bool IsComplete()
    {
        return _complete;
    }

    public int GetPoints()
    {
        return _points;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }
}