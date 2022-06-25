// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] array = new double [10];
FillArray (array);
Console.Write ("Сформирован массив: ");
PrintArray (array); Console.WriteLine();
double res = 0;
double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}

res = max - min;

Console.WriteLine ();
Console.WriteLine ("max - " + max);
Console.WriteLine ("min - " + min);
Console.WriteLine ();
Console.WriteLine ("Разница между максимальным и минимальным элементов массива - " + res);

void FillArray(double[] colFA)
{
    int length = colFA.Length;
    int index = 0;
    while (index < length)
    {
        colFA[index] = new Random().Next(1, 10) * 0.9; index++;
    }
}

void PrintArray(double[] colPA)
{
    int count = colPA.Length;
    int pos = 0;
    while (pos < count-1)
    {
        Console.Write(colPA[pos] + "; "); pos++;
    }
    Console.Write(colPA[pos]);
}
