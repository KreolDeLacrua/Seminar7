/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] FillMatrix(int rowCount, int columnsCount, int leftRange = -10, int rightRange = 10)
{
    int[,] matrix = new int[rowCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftRange, rightRange + 1);
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

double avg(int[] column)
{
    double sum = 0;
    //Console.WriteLine("column.Length =" + column.Length);
    for (int i = 0; i < column.Length; i++)
    {
        sum = sum + column[i];
    }
    double summa = sum / column.Length;
    return summa;   
}

int[,] matrix = FillMatrix(3, 5);

PrintMatrix(matrix);
Console.WriteLine("Размер столбца " + matrix.GetLength(0));
Console.WriteLine("Размер строки " + matrix.GetLength(1));


for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int[] array = new int [matrix.GetLength(0)];
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            array[j] = matrix[j, i];
        }
        Console.WriteLine("номер столбца = " + i);
        double arr = avg(array);
        Console.WriteLine("Среднее значение " + arr);
    }

