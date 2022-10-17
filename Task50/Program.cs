// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1
// 7 -> такого числа в массиве нет

Console.Clear();
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите номер строки искомого элемента: ");
int findi = int.Parse(Console.ReadLine()!);
Console.Write("Введите номер столбца искомого элемента: ");
int findj = int.Parse(Console.ReadLine()!);

if ((rows < 0) || (columns < 0))
{
    Console.WriteLine("Нужно ввести положительное значение!");
}
else
{
    double[,] array = new double[rows, columns];
    FillArray(array);
    PrintArray(array);
    FindElement(array, findi, findj);
}

void FillArray(double[,] array)
{
    Random randGenerator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round((randGenerator.Next(-10, 11) + randGenerator.NextDouble()), 2);
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindElement(double[,] array, int findi, int findj)
{
    if (findi < 0 || findi > array.GetLength(0) ||
        findj < 0 || findj > array.GetLength(1))
    {
        Console.Write("Такого элемента в массиве нет");
    }
    else
    {
        Console.WriteLine($"Искомый элемент: {array[findi-1, findj-1]}");
    }

}

// Предыдущее решение:
// Console.Clear();
// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);
// Console.Write("Введите номер строки искомого элемента: ");
// int findi = int.Parse(Console.ReadLine()!);
// Console.Write("Введите номер столбца искомого элемента: ");
// int findj = int.Parse(Console.ReadLine()!);

// if((rows < 1) || (columns < 1))
// {
//     Console.WriteLine("Нужно ввести положительные значения!");
// }
// else if ((findi > rows) || (findj > columns) || (findi < 1) || (findj < 1))
// {
//     Console.WriteLine("Такого числа нет в массиве");
// }
// else
// {
//     double[,] array = new double[rows, columns];
//     FillArray(array);
//     PrintArray(array);
//     double res = FindElement(array);
//     Console.WriteLine($"Искомый элемент: {res}");
// }

// void FillArray(double[,] array)
// {
//     Random randGenerator = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Math.Round((randGenerator.Next(-10, 11) + randGenerator.NextDouble()), 2);
//         }
//     }
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// double FindElement(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = array[findi-1, findj-1];
//         }
//     }
//     return array[findi-1, findj-1];
// }