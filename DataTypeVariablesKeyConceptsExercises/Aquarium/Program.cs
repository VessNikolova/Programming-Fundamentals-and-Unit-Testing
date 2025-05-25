
int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percentageOccupiedSpace = double.Parse(Console.ReadLine());


double allVolumeInLiters = length * width * height 0.001;  

double occupiedSpace = percentageOccupiedSpace / 0.01;

double requiredLiters = allVolumeInLiters * (1 - occupiedSpace);

Console.WriteLine($"{requiredLiters:F2}");
