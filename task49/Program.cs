/*Задача 49: Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.

Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/

int[,] FillMatrix(int rowCount, int columnsCount, int leftRange = -10, int rightRange = 10)
{
    int[,] matrix = new int[rowCount, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintMatrixS(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            if ((i + 1) % 2 == 0 && (j + 1) % 2 == 0)      
            {
                matrix[i, j] *= matrix[i, j];
            }
        }
    }
}

Console.Write("Введите m и n через Enter "); 
int m = Convert.ToInt32(Console.ReadLine()); //чисто строк
int n = Convert.ToInt32(Console.ReadLine()); //число столбцов
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrixS(matrix);
PrintMatrix(matrix);
