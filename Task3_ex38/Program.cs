// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
//минимальным элементов массива.
// [3 7 22 2 78] -> 76

// 1. задать массив
// 2. найти мин макс
// 3. вывести разницу между макс и мин

Console.Clear();
Console.Write("введите размер массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int [number];
FillArray(array);
PrintArray(array);
Console.WriteLine();

void FillArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write("]");
}

int max = array[0];
int min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    { 
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    } 
}
Console.WriteLine($"Максимальное значение => {max}, минимальное значение => {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением => {max - min}");









