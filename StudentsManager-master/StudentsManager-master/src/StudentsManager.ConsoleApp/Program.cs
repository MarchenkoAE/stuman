using StudentsManager.Models.Models;
using StudentsManager.Models.DataManipulation;

using System.Text.RegularExpressions;

var student1 = new Student { Name = "Иванов Иван", Age = 20, StudentId = "001" };
var student2 = new Student { Name = "Петров Петр", Age = 21, StudentId = "002" };
var monitor = new GroupMonitor { Name = "Сидоров Сидор", Age = 22, StudentId = "003", Responsibility = "Поддержание порядка" };

var group = new StudyGroup
{
    GroupName = "Группа А",
    Students = new List<Student> { student1, student2 },
    GroupMonitor = monitor
};

var studentDataReader = new StudentDataReader();
var studentDataWriter = new StudentDataWriter();

Console.WriteLine("Выберите режим работы:");
Console.WriteLine("1 - Отображение данных");
Console.WriteLine("2 - Редактирование данных");

var choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("Информация о группе и студентах:");
        group.DisplayGroupInfo();
        break;
    case 2:
        studentDataWriter.WriteStudentInfo(student1);
        studentDataWriter.WriteStudentInfo(monitor);

        Console.WriteLine("Измененная информация о студентах:");
        studentDataReader.ReadStudentInfo(student1);
        studentDataReader.ReadStudentInfo(monitor);
        break;
    default:
        Console.WriteLine("Неверный выбор.");
        break;
}

Console.ReadLine();