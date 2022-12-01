var input = Console.ReadLine();
var students = new List<Student>();
while (!input.Equals("END"))
{
    var info = input.Split();
    var firstname = info[0];
    var lastname = info[1];
    var marks = info.Where(x => char.IsDigit(x[0])).Select(int.Parse);
    var current = new Student
    {
        FirstName = firstname,
        LastName = lastname,
        Marks = new List<int>(marks)
    };
    students.Add(current);
    input = Console.ReadLine();
}
var selected_student = students.Where(x => x.Marks.Where(z => z == 6).Count() >= 1).Select(x => x);
foreach (var student in selected_student)
{
    Console.WriteLine($"{student.FirstName} {student.LastName}");
}