public class SimpleGoals : Goals
{
    public SimpleGoals(string name, string description, int points) : base(name, description, points)
    {

    }

    public SimpleGoals(string name, string description, int points, bool completed) : base(name, description, points, completed)
    {

    }

    public override void RecordEvent()
    {
        _complete = true;
    }

    public override int GetPoints()
    {
        if (_complete == true)
        {
            return _points;    
        }

        else
        {
            return 0;
        }
    }

    public override string GetStringRepresentation()
    {
       string stringrep = $"SimpleGoals:{GetName()}:{GetDescription()}:{_points}:{_complete}";

        return stringrep;
    }

}