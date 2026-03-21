using System.Reflection.PortableExecutable;

public abstract class Goals
{
    private string _name;
    private string _description;
    protected int _points;
    protected bool _complete;

    public Goals(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = false;
    }

    public Goals(string name, string description, int points, bool completed)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = completed;
    }
    
    public virtual void RecordEvent()
    {
        _complete = true;
    }

    public bool IsComplete()
    {
        return _complete;
    }

    public void SetComplete(bool completed)
    {
        _complete = completed;
    }

    public virtual int GetPoints()
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

    public virtual string GetStringRepresentation()
    {
        string stringrep = $"Goal:{_name}:{_description}:{_points}:{_complete}";

        return stringrep;
    }

}