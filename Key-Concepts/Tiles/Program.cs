
double bathroomwidth = double.Parse(Console.ReadLine());
double bathroomHeight = double.Parse(Console.ReadLine());
double tileWidth = double.Parse(Console.ReadLine());
double tileHeight = double.Parse(Console.ReadLine());

double bathroomArea = bathroomwidth * bathroomHeight;
double surplus = bathroomArea + (bathroomArea * 0.10);
double tileArea = tileWidth * tileHeight;
double tilesNeeded = surplus / tileArea;

Console.WriteLine(Math.Round(tilesNeeded));
