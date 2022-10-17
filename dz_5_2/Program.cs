// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(-100, 120);
    }
}
void PrintArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

Console.WriteLine("Задайте длину массива");
int count = 0;
int length;
while (true)
{
    try
    {
        length = int.Parse(Console.ReadLine());
        if (length > 20)
        {
            length = 20;
            Console.WriteLine("Не жадничаем.");
        }
        else
        {Console.WriteLine($"хорошо с {count + 1} попытки");} // :)
        Console.WriteLine();
        break;
    }
       catch (System.Exception) //обработка исключений}
    {
        switch (count)
        {
            case 0:
            Console.WriteLine("Целое положительное число");
            break;
            case 1:
            Console.WriteLine("попробуйте еще раз");
            break;
            case < 4:
            Console.WriteLine("....");
            break;
            default:
            Console.WriteLine("(-_-)");
            break;
        }
        count++;
    }
    

}

int [] array = new int [length];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int sum = 0;
for (int i = 0; i < length; i++)
{
    if (i % 2 > 0)
    {
        sum += array[i];
    }
}

Console.WriteLine($"Сумма элементов с нечетными индексами равна {sum}");
