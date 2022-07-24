// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];
int minValue = int.MaxValue;
int minIndex = 0;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
}
Console.WriteLine();
Console.Write($"Сумма элементов в каждой строке: ");
int[] summary = new int[rows];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        summary[i] += matrix[i, j];
    }
}
Console.Write($"{String.Join("; ", summary)}");
Console.WriteLine();
for (int i = 0; i < summary.Length; i++)
{
    if (minValue > summary[i])
    {
        minValue = summary[i];
        minIndex = i;
    }
}
Console.WriteLine($"наименьшая сумма элементов находится в: {minIndex} строке");
Console.WriteLine();