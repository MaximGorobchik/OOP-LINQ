using System.Security.Cryptography.X509Certificates;

var n = int.Parse(Console.ReadLine());
var list = new List<Company>();
for (int i=0;i<n;i++)
{
    var input = Console.ReadLine();
    var Name = input.Substring(1,input.IndexOf('-') - 1).Trim();
    var Amount = int.Parse(input.Substring(input.IndexOf('-') + 2, input.LastIndexOf('-') - input.IndexOf('-') - 2));
    var Product = input.Substring(input.LastIndexOf('-') + 2).Trim('|');
    var thisCompany = list.Where(x => x.CompanyName.Equals(Name)).FirstOrDefault();
    thisCompany = new Company
    {
        CompanyName = Name,
        Orders = new List<Product>()
    };
    list.Add(thisCompany);
    var thisOrder = thisCompany.Orders.Where(x => x.Name.Equals(Product)).FirstOrDefault();
    thisOrder = new Product
    {
        Name = Product,
        amount = 0
    };
    thisCompany.Orders.Add(thisOrder);
    thisOrder.amount += Amount;
}
foreach (var item in list.OrderBy(z => z.CompanyName))
{
    Console.WriteLine($"{item.CompanyName}: {string.Join(",", item.Orders.Select(x => $"{x.Name}-{x.amount}"))}");
}