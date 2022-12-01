var list = new List<Student>();
var specList = new List<StudentSpecialty>();
var input = Console.ReadLine().Trim();
while(!input.Equals("Students:"))
{
    if (input.LastIndexOf(' ') > 0)
    {
        specList.Add(new StudentSpecialty
        {
            SpecialtyName = input.Substring(0, input.LastIndexOf(' ')).Trim(),
            FacultyNumber = input.Substring(input.LastIndexOf(' ') + 1).Trim()
        });
    }
    input = Console.ReadLine().Trim();
}
while(!input.Equals("END"))
{
    if (input.IndexOf(' ') > 0)
    {
        list.Add(new Student
        {
            StudentName = input.Substring(input.IndexOf(' ') + 1).Trim(),
            Faculty = input.Substring(0, input.IndexOf(' ')).Trim()
        });
    }
    input = Console.ReadLine().Trim();
}
var student_specialty = list.Join(specList, stud => stud.Faculty, spec => spec.FacultyNumber,
    (stud, spec) => new
    {
        StudentName = stud.StudentName,
        Faculty = stud.Faculty,
        SpecialtyName = spec.SpecialtyName
    }
    );
Console.WriteLine(string.Join(Environment.NewLine, student_specialty.OrderBy(stud => stud.StudentName).Select(stud => $"{stud.StudentName} {stud.Faculty} {stud.SpecialtyName}")));

/*List<Student> Students()
{
    var input = Console.ReadLine().Trim();
    while (!input.Equals("END"))
    {
        if (input.IndexOf(' ') > 0)
        {
            list.Add(new Student
            {
                StudentName = input.Substring(input.IndexOf(' ') + 1).Trim(),
                Faculty = input.Substring(0, input.IndexOf(' ')).Trim()
            });
        }
        input = Console.ReadLine().Trim();
    }
    return list;
}*/
/*List<StudentSpecialty> Specialty()
{
    var input = Console.ReadLine().Trim();
    while (!input.Equals("Students:"))
    {
        if (input.LastIndexOf(' ') > 0)
        {
            specList.Add(new StudentSpecialty
            {
                SpecialtyName = input.Substring(0, input.LastIndexOf(' ')).Trim(),
                FacultyNumber = input.Substring(input.LastIndexOf(' ') + 1).Trim()
            });
        }
        input = Console.ReadLine().Trim();
    }
    return specList;
}*/