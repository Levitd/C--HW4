using System;
using static System.Console;

Clear();

//------------------------------------------------------------------------------------------------------
//Задача 25
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


try
{
    Write("Введите число A: ");
    int A = Convert.ToInt32(ReadLine());
    Write("Введите число B: ");
    int B = Convert.ToInt32(ReadLine());

    double DegreeNumber = GetFactNumbers(A, B);

    WriteLine($"{A} в степени {B} = {DegreeNumber}");
}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число!");
}

int GetFactNumbers(int a, int b)
{
    int fact = a;
    for (int i = 2; i <= b; i++)
    {
        fact *= a;
    }
    return fact;
}

//------------------------------------------------------
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*

int GetSumNumbers(int number)
{
    number = (number<0) ? number*(-1) : number;

    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number /= 10;
    }
    return sum;
}

Write("Введите число: ");

try
{
    int N = Convert.ToInt32(ReadLine());
    int sumNumber = GetSumNumbers(N);

    WriteLine($"Сумма Цифр в числе: {sumNumber}");
}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число!");
}
*/

//-----------------------------------------------------------------------------------

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int[] GetRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write(array[i] + " ");
    }
}


try
{
    Write("Введите кол-во элементов массива: ");
    int N = Convert.ToInt32(ReadLine());

    Write("Введите Минимальное значение массива: ");
    int min = Convert.ToInt32(ReadLine());
    
    Write("Введите Максимальное значение массива: ");
    int max = Convert.ToInt32(ReadLine());
    
    int[] ArrayBinar = GetRandomArray(N, min, max);

    WriteLine("Вариант вывода 1: ");
    PrintArray(ArrayBinar);
    
    WriteLine("\n\r" + "Вариант вывода 2: ");
    WriteLine($"[{String.Join(",", ArrayBinar)}]");

}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число!");
}
catch
{
    Write("Ошибка выполнения!");
}
*/