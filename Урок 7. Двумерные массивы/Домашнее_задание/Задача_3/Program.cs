﻿/*
Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, PrintListAvr и FindAverageInColumns.

Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся
на опрделенное число. Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы,
k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.

Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] и возвращает одномерный массив типа double. Этот
метод вычисляет среднее значение чисел в каждом столбце матрицы и сохраняет результаты в виде списка.

Метод PrintListAvr принимает одномерный массив, возвращенный методом FindAverageInColumns и выводит этот список на экран
в формате "The averages in columns are: x.x0 x.x0 x.x0 ...", где x.x0 - это значения средних значений столбцов,
округленные до двух знаков после запятой, разделенные знаком табуляции.

Пример

n = 3;
m = 4;
k = 2;

int[,] result = CreateIncreasingMatrix(n, m, k);
PrintArray(result);
PrintListAvr(FindAverageInColumns(result));

1   3   5   7   
9   11  13  15  
17  19  21  23  
The averages in columns are: 
9.00    11.00   13.00   15.00
*/


using System;

public class Answer
{
    public static void PrintArray(int[,] matrix)
    {
        // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                System.Console.Write($"{matrix[i, j]}\t");
            }
            System.Console.WriteLine();
        }
    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        // Введите свое решение ниже
        int[,] array = new int[n, m];
        array[0, 0] = 1;
        int temp = array[0, 0];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == array[0, 0])
                    continue;
                array[i, j] = temp + k;
                temp = array[i, j];
            }
        }
        return array;
    }

    static void PrintListAvr(double[] list)
    {
        // Введите свое решение ниже
    System.Console.WriteLine("The averages in columns are:");
    for (int i = 0; i < list.Length; i++)
    {
        System.Console.Write($"{list[i]:F2}\t");
    }
    
    }

    static double[] FindAverageInColumns(int[,] matrix)
    {
        // Введите свое решение ниже
    double[] result = new double[matrix.GetLength(1)];
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }
        result[i] = (double)sum / matrix.GetLength(0);
        sum = 0;
    }
    return result;
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int n, m, k;

        if (args.Length >= 3)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 4;
            m = 5;
            k = 3;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}