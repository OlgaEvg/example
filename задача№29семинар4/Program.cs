// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
int size =8;
int [] numbersArray= new int [size];

Console.Write("введите количество элементов массива : ");
int numbers = int.Parse(Console.ReadLine()!);
int [] array=new int[numbers];
for (int i=0; i<array.Length; i++)
{
    Console.Write($"введите элемент массива по индексом {i}: ");
    array[i]=int.Parse(Console.ReadLine()!);
}
Console.WriteLine("вывод  массива: ");
for (int i=0; i<array.Length; i++)
{
    Console.WriteLine(array[i]);
}
Console.ReadLine();