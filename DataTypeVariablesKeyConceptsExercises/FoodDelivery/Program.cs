
int countOfChikenMenus = int.Parse(Console.ReadLine());
int countOfFishMenus = int.Parse(Console.ReadLine());
int countOfVegetarianMenus = int.Parse(Console.ReadLine()); 

double priceForChikenMenus = countOfChikenMenus * 10.35;
double priceForFishMenus = countOfFishMenus * 12.40;
double priceForVegetarianMenus = countOfVegetarianMenus * 8.15;

double priceForAllMenus = priceForChikenMenus + priceForFishMenus + priceForVegetarianMenus;

double priceForDessert = priceForAllMenus * 0.2;  
double deliveryPrice = 2.50;

double finalPrice = priceForAllMenus + priceForDessert + deliveryPrice;

Console.WriteLine(finalPrice);
