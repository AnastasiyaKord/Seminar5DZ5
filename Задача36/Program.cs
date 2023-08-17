// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] array = GetArray(12, -999, 999);
Console.WriteLine(String.Join(" ", array));
int arrayRandomX = sumOfOddNumbers(array);

Console.WriteLine($"Колличество нечётных чисел в массиве: {arrayRandomX}");


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int sumOfOddNumbers(int[] arrayRandomX)
{
    int sumOfOddNumbers = 0;
    for (int i = 0; i < arrayRandomX.Length; i++)
    {
        if (arrayRandomX[i] % 2 != 0)
        
        sumOfOddNumbers = sumOfOddNumbers + arrayRandomX[i];
    }
    return sumOfOddNumbers;
}

