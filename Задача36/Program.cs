// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] array = GetArray(5, -999, 999);
Console.WriteLine(String.Join(" ", array));
int arrayRandomX = SumOfElementsOfOddPositions(array);

Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {arrayRandomX}");


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int SumOfElementsOfOddPositions(int[] arrayRandomX)
{
    int sumOfElements = 0;
    for (int i = 1; i < arrayRandomX.Length; i += 2)
    {
        sumOfElements += arrayRandomX[i];
    }
    return sumOfElements;
}

