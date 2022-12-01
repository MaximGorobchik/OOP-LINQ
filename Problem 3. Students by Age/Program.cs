var input = Console.ReadLine();
var students = new List<Student>();
while (!input.Equals("END"))
{
    var info = input.Split();
    var firstname = info[0];
    var lastname = info[1];
    var age = int.Parse(info[2]);
    var st = new Student(firstname, lastname,age);
    students.Add(st);
    input = Console.ReadLine();
}
const int minAge = 18; const int maxAge = 24;
var selected_student = from st in students where st.Age >= 18 && st.Age <= 24 select st;
foreach (var student in selected_student)
{
    Console.WriteLine($"{student.FirstName} {student.LastName} {student.Age}");
}