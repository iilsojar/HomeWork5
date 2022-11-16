// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int[] GetArray(int size, int minvalue, int maxvalue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minvalue, maxvalue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
    Console.WriteLine();
}

int[] array = GetArray(10, 100, 999);
int count = default;

foreach (int elem in array)
{
    if(elem % 2 == 0) count++;
}
Console.Write($"количество чётных чисел в массиве => {count}");
Console.WriteLine();
