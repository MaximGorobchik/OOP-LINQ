var input = Console.ReadLine();
var list = new List<Person>();
while(!input.Equals("END"))
{
    var current = new Person
    {
        Name = input.Substring(0, input.LastIndexOf(' ')),
        Group = int.Parse(input.Substring(input.LastIndexOf(' ') + 1))
    };
    list.Add(current);
    input= Console.ReadLine();
}
var selected_student = list.GroupBy(x => x.Group).OrderBy(z => z.Key).Select(q => $"{q.Key} - {string.Join(", ", q.Select(p => p.Name))}");
foreach (var student in selected_student)
{
    Console.WriteLine($"{student}");
}