﻿// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите 
// программу, которая покажет количество 
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();

int[] array = GetArray(12, 100, 999);
Console.WriteLine(String.Join(" ", array));
int arrayRandomX = countOfEvenNumbers(array);

Console.WriteLine($"Колличество четных чисел в массиве: {arrayRandomX}");


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int countOfEvenNumbers(int[] arrayRandomX)
{
    int countOfEvenNumbers = 0;
    for (int i = 0; i < arrayRandomX.Length; i++)
    {
        if (arrayRandomX[i] % 2 == 0)
            countOfEvenNumbers = countOfEvenNumbers + 1;
    }
    return countOfEvenNumbers;
}


