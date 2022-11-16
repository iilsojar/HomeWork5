// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int[] array = GetArray(20, 1, 21);
int sum = 0;

for (int i = 1; i < array.Length; i = i + 2)
    sum = sum + array[i];

    Console.WriteLine($"сумма элементов, cтоящих на нечётных позициях = {sum}");

//проверка
// int[] array = { 3, 7, 23, 12 };
// int sum = 0;

// for (int i = 1; i < array.Length; i = i + 2)
//     sum = sum + array[i];

// Console.WriteLine($"сумма элементов cтоящих на нечётных позициях = {sum}");

// int[] array = {-4, -6, 89, 6};
// int sum = 0;

// for (int i = 1; i < array.Length; i = i + 2)
//     sum = sum + array[i];

// Console.WriteLine($"сумма элементов cтоящих на нечётных позициях = {sum}");