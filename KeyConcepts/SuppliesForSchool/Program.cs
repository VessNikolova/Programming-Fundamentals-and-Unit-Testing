
int penPackages = int.Parse(Console.ReadLine());
int markerPackages = int.Parse(Console.ReadLine());
int litersBoardCleaner = int.Parse(Console.ReadLine());
double discount = double.Parse(Console.ReadLine());

double penPrice = penPackages * 5.80;
double markerPrice = markerPackages * 7.20;
double boardCleanerPrice = litersBoardCleaner * 1.20;

double totalSum = penPrice + markerPrice + boardCleanerPrice;

double finalSum = totalSum - (totalSum * (discount / 100));

Console.WriteLine(finalSum);
