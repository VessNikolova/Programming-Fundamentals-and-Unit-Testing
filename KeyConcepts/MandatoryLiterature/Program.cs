
int numberPages = int.Parse(Console.ReadLine());
int hourlyPages = int.Parse(Console.ReadLine());
int neededDays = int.Parse(Console.ReadLine());

int totalTime = numberPages / hourlyPages;
int requiredHoursPerDay = totalTime / neededDays;

Console.WriteLine(requiredHoursPerDay);