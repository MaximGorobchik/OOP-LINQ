using System.Security.Cryptography.X509Certificates;

var input = Console.ReadLine();
var students = new List<Student>();
while (!input.Equals("END"))
{
    var info = input.Split();
    var facultynumber = info[0];
    var marks = info.Skip(1).Select(int.Parse).ToArray();
    var current = new Student
    {
        FacultyNumber = facultynumber,
        Marks = marks
    };
    students.Add(current);
    input = Console.ReadLine();
}
string[] years = { "14", "15" };
var selected_student = students.Where(x => x.FacultyNumber.EndsWith("14") | x.FacultyNumber.EndsWith("15")).Select(x => string.Join(" ", x.Marks));
foreach (var student in selected_student)
{
    Console.WriteLine(student);
}