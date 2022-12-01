var input = Console.ReadLine();
var students = new List<Student>();
while (!input.Equals("END"))
{
    var info = input.Split();
    var firstname = info[0];
    var lastname = info[1];
    var Phone = info[2];
    var st = new Student(firstname, lastname, Phone);
    students.Add(st);
    input = Console.ReadLine();
}
string prefix1 = "02"; string prefix2 = "+3592";
var selected_student = students.Where(x => x.Phone.StartsWith(prefix1) | x.Phone.StartsWith(prefix2)).Select(x => x);
foreach (var student in selected_student)
{
    Console.WriteLine($"{student.FirstName} {student.LastName}");
}