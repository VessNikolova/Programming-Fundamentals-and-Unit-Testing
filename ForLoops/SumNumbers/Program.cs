
int count = int.Parse(Console.ReadLine());

double sum = 0.0;

for (int i = 0; i <+ count; i++)
{
    double num = double.Parse(Console.ReadLine());
    sum += num;
}

Console.WriteLine(sum);
