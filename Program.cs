//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
//Решение:

/*double[,] Create2dArray(int row, int column, int minValue, int maxValue)
{
    double[,] created2dArray = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            created2dArray[i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
            created2dArray[i, j] = Math.Round(created2dArray[i, j], 1);
        }
    }
    return created2dArray;
}
void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.WriteLine("Input number of rows (m): ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns (n): ");
int user_columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimum value of array elements: ");
int nuser_minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximum value of array elements: ");
int user_maxValue = Convert.ToInt32(Console.ReadLine());
Show2dArray(Create2dArray(user_rows, user_columns, nuser_minValue, user_maxValue));
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
//Решение:

/*int [,] Create2dArray(int row, int column, int minValue, int maxValue)
{
    int [,] created2dArray = new int [row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            created2dArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return created2dArray;
}

void Show2dArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindElement(int [,] array, int position_i, int position_j)
{
    int num_of_rows = array.GetLength(0);
    int num_of_columns = array.GetLength(1);
    if (position_i > 0 && position_i < num_of_rows && position_j > 0 && position_j < num_of_columns + 1)
    {Console.WriteLine($"[{position_i}, {position_j}] -> {array[position_i - 1,position_j - 1]}");}
    else Console.WriteLine("Такого числа в массиве нет!");
}

Console.WriteLine("Введите количество строк массива (m): ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива (n): ");
int user_columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элементов массива: ");
int nuser_minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элементов массива: ");
int user_maxValue = Convert.ToInt32(Console.ReadLine());
int [,] user_2dArray = Create2dArray(user_rows, user_columns, nuser_minValue, user_maxValue);
Show2dArray(user_2dArray);
Console.WriteLine("Введите позицию строки элемента: ");
int user_i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию столбца элемента: ");
int user_j = Convert.ToInt32(Console.ReadLine());
FindElement(user_2dArray, user_i, user_j);
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
//Решение:

int[,] Create2dArray(int row, int column, int minValue, int maxValue)
{
    int[,] createdArray = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            createdArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return createdArray;
}

void Show2dArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindArithmeticMean(int[,] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    double new_array_size = array.GetLength(0);
    double[] newArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double summ = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summ += array[i, j];
            newArray[j] = Math.Round(summ / new_array_size, 1);
        }
        Console.Write(newArray[j] + ", ");
    }
}

Console.WriteLine("Введите количество строк массива: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int user_columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элементов массива: ");
int nuser_minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элементов массива: ");
int user_maxValue = Convert.ToInt32(Console.ReadLine());
int[,] new2dArray = Create2dArray(user_rows, user_columns, nuser_minValue, user_maxValue);
Show2dArray(new2dArray);
Console.WriteLine();
FindArithmeticMean(new2dArray);


