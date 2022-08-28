// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//Console.WriteLine("введите число: ");
//int N= int.Parse(Console.ReadLine()!);
//int count=1;
//while (count<N)
 // {
 //   int B= count*count*count;
 //   count=count+1;
//  }
//Console.WriteLine(B);

Console.WriteLine("введите число: ");
int cub= Convert.ToInt32(Console.ReadLine()!);
void Cub(int[] cub)
{
    int count=0;
    int length=cub.Length;
    while (count< length)
    { 
        cub[count]=Convert.ToInt32(count*count*count);
        count++;
    }
}
void PrintArray (int [] coll)
 {
    int count= coll.Length;
    int index =0;
    while (index< count)
    {
        Console.Write(coll[index]+ " ");
        index++;
    }
 }
int [ ] array = new int [cub+1];
Cub (array);
PrintArray (array ); 