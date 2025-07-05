
int number = int.Parse(Console.ReadLine());

List<double> grades = new List<double>();

for (int i = 0; i < number; i++)
{
    double grade = double.Parse(Console.ReadLine());
    grades.Add(grade);
}

double sum = 0;

foreach (var grade in grades)
{
    sum += grade;
}

double averageGrade = sum / grades.Count;

Console.WriteLine($"{averageGrade:F2}");
