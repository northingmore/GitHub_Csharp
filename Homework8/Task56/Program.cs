// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



int SizeMasive()
{
    Console.WriteLine("Введи размер масива(строка и столбец): ");
    return int.Parse(Console.ReadLine()!);
}

int[,] CreationMasive()
{
    int ROWS = SizeMasive();
    int COLUMN = SizeMasive();
    int[,] two_DimensionalArray = new int[ROWS, COLUMN];
    return two_DimensionalArray;
}

int[,] InitionalisationMasive(int[,] masive)
{
    
    Console.WriteLine("Нажмите ENTER, если хотите получить рандомный массив или если хотите инициализировать массив сами, нажмите ESC");
    ConsoleKeyInfo key = Console.ReadKey();
    if (key.Key == ConsoleKey.Escape)
    {
        for (int i = 0; i < masive.GetLength(0); i++)
        {
            for (int j = 0; j < masive.GetLength(1); j++)
            {
                int numbI_JElement = 0;
                Console.WriteLine($"Введите число {i + 1}-того эллемента массива: ");
                numbI_JElement = int.Parse(Console.ReadLine()!);
                masive[i, j] = numbI_JElement;
            }
        }
    }
    else
    {
        for (int i = 0; i < masive.GetLength(0); i++)
        {
            for (int j = 0; j < masive.GetLength(1); j++)
            {
                masive[i,j] = Random.Shared.Next(0,1000);
            }
        }
    }
    return masive;
}

void MasivePrint(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void ElementsRowSum()
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    int[,] masive = InitionalisationMasive(CreationMasive());
    MasivePrint(masive);
    Console.WriteLine("--------------------------------------------------------------------------------");
    for (int j = 0; j < masive.GetLength(1); j++)
    {
        minRow += masive[0, j];
    }
    for (int i = 0; i < masive.GetLength(0); i++)
    {
        for (int j = 0; j < masive.GetLength(1); j++) 
            sumRow += masive[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}


ElementsRowSum();

