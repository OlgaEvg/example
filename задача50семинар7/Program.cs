﻿Console.WriteLine("введите строку:");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите столбец:");
int m=Convert.ToInt32(Console.ReadLine());
int [,] numbers=new int [10,10];
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine(" данного элемента нет ");
}
else 
{
    Console.WriteLine($"элемент {n} строки и {m}столбца равен {numbers[n-1, m-1]}");
}
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for ( int j=0; j<array.GetLength(1); j++)
        {
            array [i,j]= new Random().Next(-100,100)/10;
        }
    }
}
void PrintArray (int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j=0; j< array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.Write("]");
        Console.WriteLine( " ");
    }
}