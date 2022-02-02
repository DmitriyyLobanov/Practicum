// Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел.
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
using System;

Console.Clear();
int[] array = new int[10];

void FillArray(int[] array)


{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(' ');
    }
}
void PrintEvenArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            Console.Write(array[i]);
            Console.Write(' ');
        }
    }
}

FillArray(array);
Console.WriteLine("Изначально имеющийся массив целых чисел:");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Массив чётных целых чисел:");
PrintEvenArray(array);

