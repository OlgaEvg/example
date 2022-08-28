// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("введите число А: ");
int A =int.Parse(Console.ReadLine()!);
Console.Write("введите число В: ");
int B =int.Parse(Console.ReadLine()!);
int stepen=B;

//int AStepenB (int A, int B);
//count=1;
//while (count<B);
//{
//  A*count;
//  count++;
//}
//Console.WriteLine(AStepenB);

Math.Pow(A, stepen );
Console.WriteLine("A^B=" + Math.Pow(A, stepen ) );
