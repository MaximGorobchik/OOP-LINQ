var input = Console.ReadLine();
var students = new List<Student>();
while(!input.Equals("END"))
{
    var info = input.Split();
    var firstname = info[0];
    var lastname = info[1];
    var st = new Student(firstname,lastname);
    students.Add(st);
    input = Console.ReadLine();
}
var selected_student = from st in students where st.FirstName.CompareTo(st.LastName) < 0 select st;
foreach (var student in selected_student)
{
    Console.WriteLine($"{student.FirstName} {student.LastName}");
}