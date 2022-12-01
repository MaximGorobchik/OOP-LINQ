var input = Console.ReadLine();
var students = new List<Student>();
while(!input.Equals("END"))
{
    var info = input.Split();
    var firstname = info[0];
    var lastname = info[1];
    var group = int.Parse(info[2]);
    var st = new Student(firstname,lastname,group);
    students.Add(st);
    input = Console.ReadLine();
}
var selected_student_by_group = from st in students where st.Group == 2 orderby st.FirstName select st;
foreach (var student in selected_student_by_group)
{
    Console.WriteLine($"{student.FirstName} {student.LastName}");
}