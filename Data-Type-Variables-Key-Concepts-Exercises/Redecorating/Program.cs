
int amountOfNylon = int.Parse(Console.ReadLine());
int amountOfPaint = int.Parse(Console.ReadLine());
int quantityOfThinner = int.Parse(Console.ReadLine());
int hoursNeededForWork = int.Parse(Console.ReadLine());

double priceForNylon = (amountOfNylon + 2) * 1.50;
double priceForPaint = amountOfPaint * 1.1 * 14.50;  
double priceForThinner = quantityOfThinner * 5;
double priceForBags = 0.40;

double priceForAllMaterials = priceForNylon + priceForPaint + priceForThinner + priceForBags;

double oneHourWork = priceForAllMaterials * 0.3;    
double priceForCraftsmen = hoursNeededForWork * oneHourWork;

double finalPrice = priceForAllMaterials + priceForCraftsmen;


Console.WriteLine(finalPrice);
