double DistanceBetween (double xa, double ya, double za, double xb, double yb, double zb)
{
    double DistanceBetween= Math.Sqrt(Math.Pow((xb-xa),2)+Math.Pow((yb-ya),2)+Math.Pow((zb-za),2));
    return DistanceBetween;                  
}
Console.WriteLine("введите значение координат по оси х точки а : ");
double xa = double.Parse(Console.ReadLine()!);
Console.WriteLine("введите значение координат по оси y точки а: ");
double ya = double.Parse(Console.ReadLine()!);
Console.WriteLine("введите значение координатпо оси z точки а: ");
double za = double.Parse(Console.ReadLine()!);
Console.WriteLine("введите значение координат по оси x точки b: ");
double xb = double.Parse(Console.ReadLine()!);
Console.WriteLine("введите значение координат по оси y точки b : ");
double yb = double.Parse(Console.ReadLine()!);
Console.WriteLine("введите значение координат по оси z точки b : ");
double zb = double.Parse(Console.ReadLine()!);

double distance=DistanceBetween (xa, ya, za, xb, yb, zb);
Console.WriteLine(distance);

             