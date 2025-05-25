
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a < b && a < c && b < c){
    Console.WriteLine("Ascending");
}else if (c < a && c < b && b < a)
{
    Console.WriteLine("Descending");
}
else
{
    Console.WriteLine("Not sorted");
}
