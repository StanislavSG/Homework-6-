// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
using System;

class Program
{
    static void Main()
    {
        // Размеры массива
        const int rows = 3;
        const int cols = 4;

        // Создание двумерного массива символов
        char[,] matrix = new char[rows, cols];

        // Заполнение массива символами
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                matrix[i, j] = (char)('a' + i  *  cols + j); // Пример заполнения

        // Создание строки из символов массива
        string resultString = "";
        foreach (var item in matrix)
            resultString += item;

        Console.WriteLine(resultString);
    }
}

