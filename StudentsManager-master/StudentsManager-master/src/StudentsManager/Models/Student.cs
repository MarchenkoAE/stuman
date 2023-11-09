namespace StudentsManager.Models.Models;

public class Student
{
    public string? Name { get; set; } = null!;
    public int Age { get; set; }
    public string StudentId { get; set; } = null!;

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Имя: {Name}");
        Console.WriteLine($"Возраст: {Age}");
        Console.WriteLine($"ID студента: {StudentId}");
    }
}

public class GroupMonitor : Student
{
    public string? Responsibility { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Обязанности старосты: {Responsibility}");
    }
}