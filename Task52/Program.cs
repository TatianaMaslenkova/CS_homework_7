// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.Clear();
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

if((rows < 1) || (columns < 1))
{
    Console.WriteLine("Нужно ввести положительные значения!");
}
else
{ 
int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);
Console.Write("Среднее арифметическое по столбцам: ");
ColumnAverage(array);
}

void FillArray(int[,] array)
{
    Random randGenerator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = randGenerator.Next(-10, 11);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void ColumnAverage(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double columnSum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            columnSum += array[i, j];
        }
        Console.Write($"{Math.Round(columnSum / array.GetLength(0), 2)}; ");
    }
}