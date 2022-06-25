// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] array = new int [10];
FillArray (array);
Console.Write ("Сформирован массив: ");
PrintArray (array); Console.WriteLine();
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    if (i %2 == 1)
    {
        sum = sum + array[i];
        // Console.Write(sum + " ");
    }
}

Console.WriteLine ();
Console.WriteLine ("Сумма элементов, стоящих на нечётных позициях: " + sum);
Console.WriteLine ();

void FillArray(int[] colFA)
{
    int length = colFA.Length;
    int index = 0;
    while (index < length)
    {
        colFA[index] = new Random().Next(1, 10); index++;
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