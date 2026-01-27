using System.ComponentModel.DataAnnotations;

public class Program{

    public static void Main()
    {
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Fun Engineer";
        job1._startYear = 1992;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._company = "Meta";
        job2._jobTitle = "Not Fun Engineer";
        job2._startYear = 2000;
        job2._endYear = 2030;

        Resume myResume = new Resume();
        myResume._name = "Bob Ross";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}