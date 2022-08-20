System.Console.WriteLine("введите цифру, соответствующую дню недели:");
int A = int.Parse(Console.ReadLine()!);
if (A<6)
{
    System.Console.WriteLine("рабочий день");
}
if (A>5)
{
    System.Console.WriteLine("выходной день");
}