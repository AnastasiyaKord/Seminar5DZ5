﻿// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Задайте количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
double[] arrayRandomX = new double[number];
newArray(number);
Console.Write($"\nРазница между максимальным и минимальным элементов массива: {DifferenceMaxMinElements(arrayRandomX):F2}");

void newArray(int number)
{
    Random X = new Random();
    for (int i = 0; i < number; i++)
    {
        arrayRandomX[i] = X.NextDouble();
        Console.Write($"{arrayRandomX[i]:F2} ");
    }
}
double DifferenceMaxMinElements(double[] arrayRandomX)
{
    double min = arrayRandomX[0];
    double max = arrayRandomX[0];
    int i = 1;
    while (i < arrayRandomX.Length)
    {
        if (max < arrayRandomX[i])
        max = arrayRandomX[i];
        if (min > arrayRandomX[i])
        min = arrayRandomX[i];
        i = i + 1;
    }
    return max-min;
}

