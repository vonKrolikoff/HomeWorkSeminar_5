//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
int[] array = new int [10];
FillArray (array);
Console.WriteLine ("Сформирован массив:");
PrintArray (array);
int count = 0;
Console.WriteLine ();

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 != 1) count++;
}

Console.WriteLine();
Console.WriteLine ("Количество четных чисел в данном массиве - " + count);

void FillArray(int[] colFA)
{
    int length = colFA.Length;
    int index = 0;
    while (index < length)
    {
        colFA[index] = new Random().Next(99, 1000); index++;
    }
}

void PrintArray(int[] colPA)
{
    int count = colPA.Length;
    int pos = 0;
    while (pos < count-1)
    {
        Console.Write(colPA[pos] + ", "); pos++;
    }
    Console.Write(colPA[pos]);
}