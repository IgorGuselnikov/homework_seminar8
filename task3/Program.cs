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

int[,] firstArray = new int[rowsFirstArray, columnsFirstArray];
int[,] secondArray = new int[rowsSecondArray, coloumnsSecondArray];
int[,] multipliedArray = new int[rowsFirstArray, columnsFirstArray];

if (rowsFirstArray == rowsSecondArray && columnsFirstArray == coloumnsSecondArray)
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Первая матрица");
    Console.WriteLine();
    for (int i = 0; i < rowsFirstArray; i++)
    {
        for (int j = 0; j < columnsFirstArray; j++)
        {
            firstArray[i, j] = new Random().Next(0, 10);
            Console.Write(firstArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Вторая матрица");
    Console.WriteLine();
    for (int i = 0; i < rowsSecondArray; i++)
    {
        for (int j = 0; j < coloumnsSecondArray; j++)
        {
            secondArray[i, j] = new Random().Next(0, 10);
            Console.Write(secondArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Перемноженная матрица");
    Console.WriteLine();
    for (int i = 0; i < rowsSecondArray; i++)
    {
        for (int j = 0; j < coloumnsSecondArray; j++)
        {
            multipliedArray[i, j] = firstArray[i,j] * secondArray[i,j];
            Console.Write(multipliedArray[i, j] + "\t");
        }
        Console.WriteLine();
    }

}
else
{
    Console.WriteLine("Матрицы с веденными размерами перемножить нельзя!");
}