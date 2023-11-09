using StudentsManager.Models.Models;

namespace StudentsManager.Models.DataManipulation;

public class StudentDataWriter
{
    public void WriteStudentInfo(Student student)
    {
        Console.WriteLine("Введите новые данные о студенте:");
        Console.Write("Имя: ");
        student.Name = Console.ReadLine();
        Console.Write("Возраст: ");
        student.Age = int.Parse(Console.ReadLine());
        Console.Write("ID студента: ");
        student.StudentId = Console.ReadLine();
    }
}