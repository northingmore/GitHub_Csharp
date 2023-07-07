// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

Console.WriteLine("Введите число строки массива");
int ROWS = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов массива");
int COLUMN = int.Parse(Console.ReadLine()!);
int[,] MassInitionalisation()
{

    int[,] matrix = new int[ROWS,COLUMN];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Random.Shared.Next(0,100);
        } 
    }
    return matrix;
}

int[,] MasPrint(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i, j]}\t");
        }
        Console.WriteLine();
    }
    return mas;
}

void ArithmeticMean(int[,] mas)
{
    int i,j;
    for (j = 0; j < mas.GetLength(1); j++)
    { 
    double sum = 0;
    for (i = 0; i < mas.GetLength(0); i++)
    {
        sum = sum + mas[i,j];
    }
        Console.Write($"{(sum/i):f2}; ");
    }
}


ArithmeticMean(MasPrint(MassInitionalisation()));