System.Console.WriteLine ("введите число:");
int A= int.Parse(Console.ReadLine()!);
if (A<100)
{
Console.WriteLine ( "третьей цифры нет");
}
else
{
    while ( A>999 )
     {
       A= A / 10;
     }
        Console.WriteLine($"третья цифра : { A % 10 } ");
}
