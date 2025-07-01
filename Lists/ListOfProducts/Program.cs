
int num = int.Parse(Console.ReadLine());

List<string> products = new List<string>();

for (int i = 0; i < num; i++)
{
    string product = Console.ReadLine();
    products.Add(product);
}

int count = 1;

products.Sort();

foreach(string product in products)
{
    Console.WriteLine($"{count}.{product}");

    count++;
}