
int num = int.Parse(Console.ReadLine());

int start = 1;

while (num >= start)
{
    Console.WriteLine(start);

    start = start * 2 + 1;
}
