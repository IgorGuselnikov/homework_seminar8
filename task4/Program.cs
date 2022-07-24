// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

Console.Write("Введите ширину массива измеряемую в строках: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите высоту массива измеряемую в столбцах: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите глубину массива измеряемую в строках: ");
int depth = Convert.ToInt32(Console.ReadLine());

int[,,] GetArray(int rows, int coloumns, int depth, int min, int max)
{
    int[,,] matrix = new int [rows,coloumns,depth];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                matrix[i, j, k] = new Random().Next(min, max);
            }
        }
    }
    return matrix;
}

void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i, j, k] + $"({i},{j},{k})" + "\t");
            }
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}

int [,,] myArray = GetArray(rows, columns, depth, 10, 99);
PrintArray(myArray);