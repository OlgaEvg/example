Console.WriteLine ("введите первое число");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine ("введите второе число");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine ("введите третье число");
int C= int.Parse(Console.ReadLine()!);

int max = A;

if (A > max) max = A;
if (B > max) max = B;
if (C > max) max = C;

Console.Write ("max =");
Console.WriteLine (max);


