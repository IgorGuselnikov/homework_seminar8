// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49


Console.Write("Введите количество строк первой матрицы: ");
int rowsFirstArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int columnsFirstArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк второй матрицы: ");
int rowsSecondArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int coloumnsSecondArray = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int rows, int coloumns, int min, int max)
{
    int[,] matrix = new int [rows,coloumns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}


int[,] MultipliedArray(int[,] firstArray, int[,] secondArray)
{
    int[,] multipliedArray = new int [firstArray.GetLength(0),firstArray.GetLength(1)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < firstArray.GetLength(1); j++)
        {
            multipliedArray[i, j] = firstArray[i, j] * secondArray[i, j];
        }
    }
    return  multipliedArray;
}


if (rowsFirstArray == rowsSecondArray && columnsFirstArray == coloumnsSecondArray)
{
    int[,] firstArray = GetArray(rowsFirstArray, columnsFirstArray, 0, 15);
    Console.WriteLine();
    Console.WriteLine("Первая матрица");
    Console.WriteLine();
    PrintArray(firstArray);
    int[,] secondArray = GetArray(rowsSecondArray, coloumnsSecondArray, 0, 15);
    Console.WriteLine();
    Console.WriteLine("Вторая матрица");
    Console.WriteLine();
    PrintArray(secondArray);
    int [,] multipliedArray = MultipliedArray (firstArray, secondArray);
    Console.WriteLine();
    Console.WriteLine("Перемноженная матрица");
    Console.WriteLine();
    PrintArray(multipliedArray);
}
else
{
    Console.WriteLine("Матрицы с веденными размерами перемножить нельзя!");
}

