//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

void FillArray(double[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(-100, 120) + Math.Round((new Random().NextDouble()), 2);
    }
}
void PrintArray(double[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        if (i < length - 1 & i > 0)
        { Console.Write("; ");} // ; - между элементами
        Console.Write(arr[i]);
    }
}

double[] array = new double[10]; // массив большой нам не нужен
FillArray(array);

double min = array [0];
double max = min;

for (int i = 0; i < 10; i++)
{
    if (array [i] < min)
    {
        min = array [i];
    }
    else
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
}

if (min == max)
{
    Console.WriteLine("равенство");
}
else
{
    Console.WriteLine($"разница между максимальным и минимальными элементами массива равна {max - min}");
}

