var input = Console.ReadLine();
var students = new List<Student>();
while (!input.Equals("END"))
{
    var info = input.Split();
    var firstname = info[0];
    var lastname = info[1];
    var Email= info[2];
    var st = new Student(firstname, lastname,Email);
    students.Add(st);
    input = Console.ReadLine();
}
string email = "@gmail.com";
var selected_student = students.Where(x => x.Email.Contains(email)).Select(x => x);
foreach (var student in selected_student)
{
    Console.WriteLine($"{student.FirstName} {student.LastName}");
}