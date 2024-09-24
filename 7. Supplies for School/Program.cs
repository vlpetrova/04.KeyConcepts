int numPenPkg = int.Parse(Console.ReadLine());
int numMarkersPkg = int.Parse(Console.ReadLine());
int litersBoardCleaner = int.Parse(Console.ReadLine());
int discountPercent = int.Parse(Console.ReadLine());

double pricePenPkgBgn = numPenPkg * 5.80;
double priceMarkerPkgBgn = numMarkersPkg * 7.20;
double priceBorderCleanerLtsBgn = litersBoardCleaner * 1.20;
double calcDiscount = discountPercent * 1.0 / 100;

double priceAllMaretials = pricePenPkgBgn + priceMarkerPkgBgn + priceBorderCleanerLtsBgn;

Console.WriteLine(priceAllMaretials - (priceAllMaretials * calcDiscount));
