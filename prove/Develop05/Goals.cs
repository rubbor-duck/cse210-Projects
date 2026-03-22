using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices.Marshalling;

public abstract class Goals
{
    private string _name;
    private string _description;
    protected int _points;
    protected bool _complete;

    // two different constructors
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

    // changes the _complete to true or adds to the complete
    public virtual void RecordEvent()
    {
        _complete = true;
    }

    // returns the _complete
    public bool IsComplete()
    {
        return _complete;
    }

    // sets the _complete
    public void SetComplete(bool completed)
    {
        _complete = completed;
    }

    // returns the total points of the goal
    public virtual int GetPoints()
    {
        return _points;
    }

    // Gets the _name
    public string GetName()
    {
        return _name;
    }

    // Gets the _description
    public string GetDescription()
    {
        return _description;
    }

    // Combines the attributes into one string separated by ":"
    public virtual string GetStringRepresentation()
    {
        // Goal type: Name: description: # of points worth: is it complete
        string stringrep = $"Goal:{_name}:{_description}:{_points}:{_complete}";

        return stringrep;
    }

    // prepares the attributes to be displayed to the user
    public virtual string DisplayStringDetails()
    {
        string checkbox;

        // adds a checkbox for the user to see if the goal is complete or not
        if (IsComplete() == true)
        {
            checkbox = "[x]";
        }

        else
        {
            checkbox = "[_]";
        }

        // formats the data into one string to be printed to the user
        string details = $"Name: {GetName()}\nDescription: {GetDescription()}\n# of points worth: {_points}\nIs it complete: {checkbox}";

        return details;
    }
}