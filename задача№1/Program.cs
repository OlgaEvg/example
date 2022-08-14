int a = 5;
int b = 7;
int max=a;
int min=b;
if (a>max) max=a;
if (b>max) max=b;
if (a<min) min=a;
if (b<min) min=b;

Console.Write("max=");
Console.WriteLine(max);

Console.Write("min=");
Console.WriteLine(min);

