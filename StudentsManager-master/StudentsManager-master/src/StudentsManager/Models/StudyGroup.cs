namespace StudentsManager.Models.Models;

public class StudyGroup
{
    public string GroupName { get; set; } = null!;
    public List<Student> Students { get; set; } = new List<Student>();
    public GroupMonitor? GroupMonitor { get; set; }

    public void DisplayGroupInfo()
    {
        Console.WriteLine($"Название группы: {GroupName}");
        Console.WriteLine("Студенты в группе:");
        foreach (var student in Students)
        {
            student.DisplayInfo();
            Console.WriteLine();
        }

        if (GroupMonitor != null)
        {
            Console.WriteLine("Староста группы:");
            GroupMonitor.DisplayInfo();
        }
    }
}