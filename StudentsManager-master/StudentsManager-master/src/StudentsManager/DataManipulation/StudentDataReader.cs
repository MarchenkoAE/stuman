using StudentsManager.Models.Models;

namespace StudentsManager.Models.DataManipulation;

public class StudentDataReader
{
    public void ReadStudentInfo(Student student)
    {
        Console.WriteLine("Информация о студенте:");
        student.DisplayInfo();
    }
}