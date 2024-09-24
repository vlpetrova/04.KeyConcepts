double bathWidth = double.Parse(Console.ReadLine());
double bathHeight = double.Parse(Console.ReadLine());
double tileWidth = double.Parse(Console.ReadLine());
double tileHeight = double.Parse(Console.ReadLine());

double bathArea = bathWidth * bathHeight;
bathArea = bathArea + 0.10 * bathArea;

double tileSurface = tileWidth * tileHeight;
double totalTiles = bathArea / tileSurface;

Console.WriteLine(Math.Round(totalTiles));

