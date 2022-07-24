// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8


Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);



int[,] GetArray(int rows, int coloumns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(0, 20);
        }
    }
    return matrix;
}

void BubbleSortArray(int[] inputArray)
{
    for (int i = 0; i < inputArray.Length; i++)
    {
        for (int j = 0; j < inputArray.Length - i - 1; j++)
        {
            if (inputArray[j] > inputArray[j + 1])
            {
                int temp = inputArray[j];
                inputArray[j] = inputArray[j + 1];
                inputArray[j + 1] = temp;
            }
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
    Console.WriteLine();
    }
}

int [,] SortArray(int[,] matrix)
{
    int[] tempArray = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            tempArray[j] = matrix[i, j];
        BubbleSortArray(tempArray);
        for (int k = 0; k < tempArray.Length; k++)
        {
                matrix[i, k] = tempArray[k];
        }
    }
    return matrix;
}













