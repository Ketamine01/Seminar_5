//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int n = new Random().Next(2,11);
int[] array = new int [n];

void FillPrintArray (int [] arr)
{
    for (int i = 0; 1 < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
        Console.WriteLine(arr[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

int CountEven (int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
FillPrintArray(array);

Console.WriteLine($"Количество четных {CountEven(array)} чисел в массиве");
Console.WriteLine();